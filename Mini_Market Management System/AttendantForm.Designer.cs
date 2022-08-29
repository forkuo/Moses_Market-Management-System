namespace Moses_Market_Management_System
{
    partial class AttendantForm
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.attendantpanel = new System.Windows.Forms.Panel();
            this.salesBtn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Navy;
            this.sidepanel.Controls.Add(this.logout);
            this.sidepanel.Controls.Add(this.salesBtn);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(171, 450);
            this.sidepanel.TabIndex = 0;
            // 
            // attendantpanel
            // 
            this.attendantpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendantpanel.Location = new System.Drawing.Point(171, 0);
            this.attendantpanel.Name = "attendantpanel";
            this.attendantpanel.Size = new System.Drawing.Size(629, 450);
            this.attendantpanel.TabIndex = 1;
            this.attendantpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // salesBtn
            // 
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.ForeColor = System.Drawing.Color.White;
            this.salesBtn.Location = new System.Drawing.Point(6, 12);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(159, 43);
            this.salesBtn.TabIndex = 0;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(0, 407);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(171, 43);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // AttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attendantpanel);
            this.Controls.Add(this.sidepanel);
            this.Name = "AttendantForm";
            this.Text = "Moses Market | Attendant";
            this.sidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Panel attendantpanel;
    }
}