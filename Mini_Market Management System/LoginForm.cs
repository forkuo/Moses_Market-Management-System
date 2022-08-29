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
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Moses_Market_Management_System
{
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public static string sellerName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Goldenrod;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            // open connection to database
            dBCon.OpenCon();

            // authenticate for an admin
            if (TextBox_username.Text != "" && TextBox_password.Text != "" && (comboBox_role.Text == "Admin" || comboBox_role.Text == "Attendant") )
            {
                try
                {
                    // checker
                    bool UserIsFound = false;
                    string insertQuery = "select * from user where username='" + TextBox_username.Text + "'&& password='" + TextBox_password.Text + "'&& role='" + comboBox_role.Text  + "'" ;
                    
                    // execute query and read output
                    MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    // check if query exist
                    if (reader.HasRows)
                    {
                        UserIsFound = true;
                    } else
                    {
                        UserIsFound =false;
                    }
                    reader.Close();

                    // now redirect to the appropriate page
                    if (UserIsFound)
                    {
                        if(comboBox_role.Text == "Admin")
                        {
                            this.Hide();

                            adminForm admin = new adminForm();
                            admin.Show();
                        } else
                        {
                            this.Hide();
                            AttendantForm attendant = new AttendantForm();
                            attendant.Show();
                            MessageBox.Show("User Has been logged in as an Attendant!!!!!!!!!"); 
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("No User if Found For This User Credentials");
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
            }
            else
            {
                MessageBox.Show("Username, Password and Role Fields are All Required!");
                dBCon.CloseCon();
            }
            dBCon.CloseCon();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
