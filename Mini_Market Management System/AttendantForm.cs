using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moses_Market_Management_System
{
    public partial class AttendantForm : Form
    {
        public AttendantForm()
        {
            InitializeComponent();
        }


        private Form currentForm = null;

        private void SetCurrentForm(Form form)
        {
            if (currentForm != null) currentForm.Close();

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            attendantpanel.Controls.Add(form);
            attendantpanel.Tag = form;

            form.BringToFront();
            form.Show();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            SellingForm sales = new SellingForm();
            SetCurrentForm(sales);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
