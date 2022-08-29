using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Moses_Market_Management_System
{
    class DBConnect
    {
        public static string connectionString = @"server=localhost;userid=root;password=;database=mosesmarket;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public MySqlConnection GetCon()
        {
            return connection;
        }

        public void OpenCon()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseCon()
        {
            try
            {
                connection.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
