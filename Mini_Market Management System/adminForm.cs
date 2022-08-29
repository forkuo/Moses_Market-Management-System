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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void adminFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form currentForm = null;

        private void SetCurrentForm(Form form)
        {
            if (currentForm != null) currentForm.Close();

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            adminFormPanel.Controls.Add(form);
            adminFormPanel.Tag = form;

            form.BringToFront();
            form.Show();
        }

        private void categoryTab_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            SetCurrentForm(category);
        }

        private void poductTab_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            SetCurrentForm(product);
        }

        private void SellerTab_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            SetCurrentForm(seller);
        }

        private void logoutTab_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm login = new LoginForm();
            login.Show();
        }

        private void salesTab_Click(object sender, EventArgs e)
        {
            SellingForm sales = new SellingForm();
            SetCurrentForm(sales);
        }
    }
}
