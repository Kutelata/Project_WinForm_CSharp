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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.computer_area_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmTurnOn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrderFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPay = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchComputer = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTime = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputerByArea)).BeginInit();
            this.contextData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputerByArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComputerByArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputerByArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.computer_id,
            this.computer_name,
            this.computer_status,
            this.computer_area_id});
            this.dgvComputerByArea.ContextMenuStrip = this.contextData;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComputerByArea.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComputerByArea.Location = new System.Drawing.Point(12, 119);
            this.dgvComputerByArea.Name = "dgvComputerByArea";
            this.dgvComputerByArea.ReadOnly = true;
            this.dgvComputerByArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputerByArea.Size = new System.Drawing.Size(1076, 238);
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
            this.computer_name.HeaderText = "Máy tính";
            this.computer_name.Name = "computer_name";
            this.computer_name.ReadOnly = true;
            // 
            // computer_status
            // 
            this.computer_status.DataPropertyName = "Status";
            this.computer_status.HeaderText = "Trạng thái";
            this.computer_status.Name = "computer_status";
            this.computer_status.ReadOnly = true;
            // 
            // computer_area_id
            // 
            this.computer_area_id.DataPropertyName = "Area_Id";
            this.computer_area_id.HeaderText = "Area_Id";
            this.computer_area_id.Name = "computer_area_id";
            this.computer_area_id.ReadOnly = true;
            this.computer_area_id.Visible = false;
            // 
            // contextData
            // 
            this.contextData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTurnOn,
            this.tsmOrderFood,
            this.tsmPay});
            this.contextData.Name = "contextData";
            this.contextData.Size = new System.Drawing.Size(135, 70);
            // 
            // tsmTurnOn
            // 
            this.tsmTurnOn.Name = "tsmTurnOn";
            this.tsmTurnOn.Size = new System.Drawing.Size(134, 22);
            this.tsmTurnOn.Text = "Bật máy";
            this.tsmTurnOn.Click += new System.EventHandler(this.tsmTurnOn_Click);
            // 
            // tsmOrderFood
            // 
            this.tsmOrderFood.Name = "tsmOrderFood";
            this.tsmOrderFood.Size = new System.Drawing.Size(134, 22);
            this.tsmOrderFood.Text = "Đặt đồ ăn";
            this.tsmOrderFood.Click += new System.EventHandler(this.tsmOrderFood_Click);
            // 
            // tsmPay
            // 
            this.tsmPay.Name = "tsmPay";
            this.tsmPay.Size = new System.Drawing.Size(134, 22);
            this.tsmPay.Text = "Thanh toán";
            this.tsmPay.Click += new System.EventHandler(this.tsmPay_Click);
            // 
            // txtSearchComputer
            // 
            this.txtSearchComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchComputer.Location = new System.Drawing.Point(815, 84);
            this.txtSearchComputer.Name = "txtSearchComputer";
            this.txtSearchComputer.Size = new System.Drawing.Size(273, 29);
            this.txtSearchComputer.TabIndex = 40;
            this.txtSearchComputer.TextChanged += new System.EventHandler(this.txtSearchComputer_TextChanged);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(187, 605);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 33);
            this.lblGrandTotal.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 33);
            this.label4.TabIndex = 46;
            this.label4.Text = "Grand Total :";
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFood.Location = new System.Drawing.Point(571, 400);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.Size = new System.Drawing.Size(517, 190);
            this.dgvFood.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "Foods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "Time Use";
            // 
            // dgvTime
            // 
            this.dgvTime.AllowUserToAddRows = false;
            this.dgvTime.AllowUserToDeleteRows = false;
            this.dgvTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTime.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTime.Location = new System.Drawing.Point(12, 400);
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.ReadOnly = true;
            this.dgvTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTime.Size = new System.Drawing.Size(517, 190);
            this.dgvTime.TabIndex = 41;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTime);
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
            this.contextData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextData;
        private System.Windows.Forms.ToolStripMenuItem tsmTurnOn;
        private System.Windows.Forms.ToolStripMenuItem tsmOrderFood;
        private System.Windows.Forms.ToolStripMenuItem tsmPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_area_id;
        public System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvTime;
    }
}