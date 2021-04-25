namespace InternetCafe.UI.Employee
{
    partial class frmHome
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtVendorName = new System.Windows.Forms.Label();
            this.pbVendor = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbRoleUser = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.txtVendorName);
            this.panelTop.Controls.Add(this.pbVendor);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 68);
            this.panelTop.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::InternetCafe.Properties.Resources.Logout;
            this.btnLogout.Location = new System.Drawing.Point(922, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 68);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtVendorName
            // 
            this.txtVendorName.AutoSize = true;
            this.txtVendorName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.ForeColor = System.Drawing.Color.White;
            this.txtVendorName.Location = new System.Drawing.Point(98, 22);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(75, 25);
            this.txtVendorName.TabIndex = 2;
            this.txtVendorName.Text = "label1";
            // 
            // pbVendor
            // 
            this.pbVendor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbVendor.Image = global::InternetCafe.Properties.Resources.Vendor;
            this.pbVendor.Location = new System.Drawing.Point(0, 0);
            this.pbVendor.Name = "pbVendor";
            this.pbVendor.Size = new System.Drawing.Size(68, 68);
            this.pbVendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVendor.TabIndex = 1;
            this.pbVendor.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1011, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 68);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbRoleUser
            // 
            this.cbRoleUser.BackColor = System.Drawing.Color.White;
            this.cbRoleUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoleUser.FormattingEnabled = true;
            this.cbRoleUser.Location = new System.Drawing.Point(12, 85);
            this.cbRoleUser.Name = "cbRoleUser";
            this.cbRoleUser.Size = new System.Drawing.Size(343, 28);
            this.cbRoleUser.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 519);
            this.dataGridView1.TabIndex = 24;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbRoleUser);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label txtVendorName;
        private System.Windows.Forms.PictureBox pbVendor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbRoleUser;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}