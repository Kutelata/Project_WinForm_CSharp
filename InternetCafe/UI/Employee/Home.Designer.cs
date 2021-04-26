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
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.dgvComputerByArea = new System.Windows.Forms.DataGridView();
            this.computer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_area_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchComputer = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputerByArea)).BeginInit();
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
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.Color.White;
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(12, 85);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(273, 28);
            this.cbArea.TabIndex = 23;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // dgvComputerByArea
            // 
            this.dgvComputerByArea.AllowUserToAddRows = false;
            this.dgvComputerByArea.AllowUserToDeleteRows = false;
            this.dgvComputerByArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComputerByArea.BackgroundColor = System.Drawing.Color.White;
            this.dgvComputerByArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputerByArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.computer_id,
            this.computer_name,
            this.computer_status,
            this.computer_order,
            this.computer_area,
            this.computer_area_id});
            this.dgvComputerByArea.Location = new System.Drawing.Point(12, 119);
            this.dgvComputerByArea.Name = "dgvComputerByArea";
            this.dgvComputerByArea.ReadOnly = true;
            this.dgvComputerByArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputerByArea.Size = new System.Drawing.Size(1076, 519);
            this.dgvComputerByArea.TabIndex = 24;
            this.dgvComputerByArea.SelectionChanged += new System.EventHandler(this.dgvComputerinArea_SelectionChanged);
            // 
            // computer_id
            // 
            this.computer_id.DataPropertyName = "Entity_Id";
            this.computer_id.HeaderText = "Id";
            this.computer_id.Name = "computer_id";
            this.computer_id.ReadOnly = true;
            // 
            // computer_name
            // 
            this.computer_name.DataPropertyName = "Name";
            this.computer_name.HeaderText = "Computer";
            this.computer_name.Name = "computer_name";
            this.computer_name.ReadOnly = true;
            // 
            // computer_status
            // 
            this.computer_status.DataPropertyName = "Status";
            this.computer_status.HeaderText = "Status";
            this.computer_status.Name = "computer_status";
            this.computer_status.ReadOnly = true;
            // 
            // computer_order
            // 
            this.computer_order.DataPropertyName = "Order";
            this.computer_order.HeaderText = "Order";
            this.computer_order.Name = "computer_order";
            this.computer_order.ReadOnly = true;
            // 
            // computer_area
            // 
            this.computer_area.DataPropertyName = "Area";
            this.computer_area.HeaderText = "Area";
            this.computer_area.Name = "computer_area";
            this.computer_area.ReadOnly = true;
            // 
            // computer_area_id
            // 
            this.computer_area_id.DataPropertyName = "Area_Id";
            this.computer_area_id.HeaderText = "Area_Id";
            this.computer_area_id.Name = "computer_area_id";
            this.computer_area_id.ReadOnly = true;
            // 
            // txtSearchComputer
            // 
            this.txtSearchComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchComputer.Location = new System.Drawing.Point(815, 84);
            this.txtSearchComputer.Name = "txtSearchComputer";
            this.txtSearchComputer.Size = new System.Drawing.Size(273, 29);
            this.txtSearchComputer.TabIndex = 40;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.txtSearchComputer);
            this.Controls.Add(this.dgvComputerByArea);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputerByArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label txtVendorName;
        private System.Windows.Forms.PictureBox pbVendor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.DataGridView dgvComputerByArea;
        private System.Windows.Forms.TextBox txtSearchComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_area_id;
    }
}