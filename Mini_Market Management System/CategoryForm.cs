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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Moses_Market_Management_System
{
    public partial class CategoryForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Category";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_category.DataSource = table;
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (categoryDescription.Text != "" && categoryDescription.Text != "")
            {
                try
                {
                    string insertQuery = "INSERT INTO category(name, description) VALUES('" + categoryName.Text + "', '" + categoryDescription.Text + "')";
                    MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("You must enter category name and description");
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGridView_category_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = DataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            categoryName.Text= DataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            categoryDescription.Text= DataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void clear()
        {
            TextBox_id.Clear();
            categoryName.Clear();
            categoryDescription.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
           
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
