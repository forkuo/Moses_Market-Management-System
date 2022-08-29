using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Moses_Market_Management_System
{
    public partial class ProductForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();


        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM category";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            productCategory.DataSource = table;
            productCategory.ValueMember = "name";
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "name";
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Product";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void clear()
        {
            productID.Clear();
            productName.Clear();
            productPrice.Clear();
            productQuantity.Clear();
            productCategory.SelectedIndex = 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(productName.Text != "" && productPrice.Text != "")
            {
                try
                {
                    string insertQuery = "INSERT INTO product(productName, productPrice, productQuantity, productCategory) VALUES('" + productName.Text + "', '" + productPrice.Text + "', '" + productQuantity.Text + "', '" + productCategory.Text + "')";
                    MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Name and Price fields must be entered");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (productName.Text != "" && productPrice.Text != "")
            {
                try
                {
                    string insertQuery = "UPDATE product set id='" + productID.Text + "',productName='" + productName.Text + "',productCategory='" + productCategory.Text + "',productPrice='" + productPrice.Text + "' WHERE id='" + productID.Text + "'" ;
                    MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Name and Price fields must be entered");
            }
        }

     

        private void dataGridView_product_Click_1(object sender, EventArgs e)
        {
            productID.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            productName.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            productPrice.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            productQuantity.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            productCategory.SelectedValue = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            dBCon.OpenCon();
            try
            {
                if (productName.Text == "" && productID.Text != "")
                {
                    MessageBox.Show("Please enter prduct name to delete", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM product WHERE productName='" + productName.Text + "'";
                    MySqlCommand command = new MySqlCommand(deleteQuery, dBCon.GetCon());
                    
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dBCon.CloseCon();
            }
            dBCon.CloseCon();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Product WHERE ProdCat='"+comboBox_search.SelectedValue.ToString()+"'";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

       

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
