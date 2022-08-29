namespace Moses_Market_Management_System
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.logoutTab = new System.Windows.Forms.Button();
            this.reorderTab = new System.Windows.Forms.Button();
            this.salesTab = new System.Windows.Forms.Button();
            this.SellerTab = new System.Windows.Forms.Button();
            this.poductTab = new System.Windows.Forms.Button();
            this.categoryTab = new System.Windows.Forms.Button();
            this.adminFormPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Purple;
            this.sidePanel.Controls.Add(this.logoutTab);
            this.sidePanel.Controls.Add(this.reorderTab);
            this.sidePanel.Controls.Add(this.salesTab);
            this.sidePanel.Controls.Add(this.SellerTab);
            this.sidePanel.Controls.Add(this.poductTab);
            this.sidePanel.Controls.Add(this.categoryTab);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(148, 450);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminFormPanel_Paint);
            // 
            // logoutTab
            // 
            this.logoutTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logoutTab.ForeColor = System.Drawing.Color.White;
            this.logoutTab.Location = new System.Drawing.Point(0, 413);
            this.logoutTab.Name = "logoutTab";
            this.logoutTab.Size = new System.Drawing.Size(148, 37);
            this.logoutTab.TabIndex = 5;
            this.logoutTab.Text = "Logout";
            this.logoutTab.UseVisualStyleBackColor = true;
            this.logoutTab.Click += new System.EventHandler(this.logoutTab_Click);
            // 
            // reorderTab
            // 
            this.reorderTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.reorderTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reorderTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reorderTab.ForeColor = System.Drawing.Color.White;
            this.reorderTab.Location = new System.Drawing.Point(0, 148);
            this.reorderTab.Name = "reorderTab";
            this.reorderTab.Size = new System.Drawing.Size(148, 37);
            this.reorderTab.TabIndex = 4;
            this.reorderTab.Text = "Reorder";
            this.reorderTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reorderTab.UseVisualStyleBackColor = true;
            // 
            // salesTab
            // 
            this.salesTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.salesTab.ForeColor = System.Drawing.Color.White;
            this.salesTab.Location = new System.Drawing.Point(0, 111);
            this.salesTab.Name = "salesTab";
            this.salesTab.Size = new System.Drawing.Size(148, 37);
            this.salesTab.TabIndex = 3;
            this.salesTab.Text = "Sales";
            this.salesTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesTab.UseVisualStyleBackColor = true;
            this.salesTab.Click += new System.EventHandler(this.salesTab_Click);
            // 
            // SellerTab
            // 
            this.SellerTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellerTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SellerTab.ForeColor = System.Drawing.Color.White;
            this.SellerTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellerTab.Location = new System.Drawing.Point(0, 74);
            this.SellerTab.Name = "SellerTab";
            this.SellerTab.Size = new System.Drawing.Size(148, 37);
            this.SellerTab.TabIndex = 2;
            this.SellerTab.Text = "Seller";
            this.SellerTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellerTab.UseVisualStyleBackColor = true;
            this.SellerTab.Click += new System.EventHandler(this.SellerTab_Click);
            // 
            // poductTab
            // 
            this.poductTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.poductTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poductTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.poductTab.ForeColor = System.Drawing.Color.White;
            this.poductTab.Location = new System.Drawing.Point(0, 37);
            this.poductTab.Name = "poductTab";
            this.poductTab.Size = new System.Drawing.Size(148, 37);
            this.poductTab.TabIndex = 1;
            this.poductTab.Text = "Product";
            this.poductTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.poductTab.UseVisualStyleBackColor = true;
            this.poductTab.Click += new System.EventHandler(this.poductTab_Click);
            // 
            // categoryTab
            // 
            this.categoryTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.categoryTab.ForeColor = System.Drawing.Color.White;
            this.categoryTab.Location = new System.Drawing.Point(0, 0);
            this.categoryTab.Name = "categoryTab";
            this.categoryTab.Size = new System.Drawing.Size(148, 37);
            this.categoryTab.TabIndex = 0;
            this.categoryTab.Text = "Category";
            this.categoryTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryTab.UseVisualStyleBackColor = true;
            this.categoryTab.Click += new System.EventHandler(this.categoryTab_Click);
            // 
            // adminFormPanel
            // 
            this.adminFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFormPanel.Location = new System.Drawing.Point(148, 0);
            this.adminFormPanel.Name = "adminFormPanel";
            this.adminFormPanel.Size = new System.Drawing.Size(652, 450);
            this.adminFormPanel.TabIndex = 1;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminFormPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "adminForm";
            this.Text = "Moses Market | Admin";
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button logoutTab;
        private System.Windows.Forms.Button reorderTab;
        private System.Windows.Forms.Button salesTab;
        private System.Windows.Forms.Button SellerTab;
        private System.Windows.Forms.Button poductTab;
        private System.Windows.Forms.Button categoryTab;
        private System.Windows.Forms.Panel adminFormPanel;
    }
}