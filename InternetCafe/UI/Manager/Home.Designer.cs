
namespace InternetCafe.UI.Manager
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
            this.txtAdminName = new System.Windows.Forms.Label();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.homeTabPage = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.areaTabPage = new MetroFramework.Controls.MetroTabPage();
            this.gbArea = new System.Windows.Forms.GroupBox();
            this.txtNameArea = new System.Windows.Forms.TextBox();
            this.lbPriceArea = new System.Windows.Forms.Label();
            this.btnSaveArea = new System.Windows.Forms.Button();
            this.txtPriceArea = new System.Windows.Forms.TextBox();
            this.lbNameArea = new System.Windows.Forms.Label();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.btnDeleteArea = new System.Windows.Forms.Button();
            this.btnSearchArea = new System.Windows.Forms.Button();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.txtSearchArea = new System.Windows.Forms.TextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.area_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.areaTabPage.SuspendLayout();
            this.gbArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.txtAdminName);
            this.panelTop.Controls.Add(this.pbAdmin);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1107, 68);
            this.panelTop.TabIndex = 0;
            // 
            // txtAdminName
            // 
            this.txtAdminName.AutoSize = true;
            this.txtAdminName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.ForeColor = System.Drawing.Color.White;
            this.txtAdminName.Location = new System.Drawing.Point(124, 22);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(75, 25);
            this.txtAdminName.TabIndex = 2;
            this.txtAdminName.Text = "label1";
            // 
            // pbAdmin
            // 
            this.pbAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAdmin.Location = new System.Drawing.Point(0, 0);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(100, 68);
            this.pbAdmin.TabIndex = 1;
            this.pbAdmin.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1018, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 68);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.homeTabPage);
            this.mainTabControl.Controls.Add(this.areaTabPage);
            this.mainTabControl.Controls.Add(this.metroTabPage3);
            this.mainTabControl.Controls.Add(this.metroTabPage4);
            this.mainTabControl.Controls.Add(this.metroTabPage5);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 68);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 1;
            this.mainTabControl.Size = new System.Drawing.Size(1107, 579);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.UseSelectable = true;
            // 
            // homeTabPage
            // 
            this.homeTabPage.Controls.Add(this.button1);
            this.homeTabPage.HorizontalScrollbarBarColor = true;
            this.homeTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.homeTabPage.HorizontalScrollbarSize = 10;
            this.homeTabPage.Location = new System.Drawing.Point(4, 38);
            this.homeTabPage.Name = "homeTabPage";
            this.homeTabPage.Size = new System.Drawing.Size(1099, 537);
            this.homeTabPage.TabIndex = 0;
            this.homeTabPage.Text = "Home";
            this.homeTabPage.VerticalScrollbarBarColor = true;
            this.homeTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.homeTabPage.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // areaTabPage
            // 
            this.areaTabPage.Controls.Add(this.gbArea);
            this.areaTabPage.Controls.Add(this.btnDeleteArea);
            this.areaTabPage.Controls.Add(this.btnSearchArea);
            this.areaTabPage.Controls.Add(this.dgvArea);
            this.areaTabPage.Controls.Add(this.txtSearchArea);
            this.areaTabPage.HorizontalScrollbarBarColor = true;
            this.areaTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.areaTabPage.HorizontalScrollbarSize = 10;
            this.areaTabPage.Location = new System.Drawing.Point(4, 38);
            this.areaTabPage.Name = "areaTabPage";
            this.areaTabPage.Size = new System.Drawing.Size(1099, 537);
            this.areaTabPage.TabIndex = 1;
            this.areaTabPage.Text = "Area";
            this.areaTabPage.VerticalScrollbarBarColor = true;
            this.areaTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.areaTabPage.VerticalScrollbarSize = 10;
            // 
            // gbArea
            // 
            this.gbArea.BackColor = System.Drawing.Color.White;
            this.gbArea.Controls.Add(this.txtNameArea);
            this.gbArea.Controls.Add(this.lbPriceArea);
            this.gbArea.Controls.Add(this.btnSaveArea);
            this.gbArea.Controls.Add(this.txtPriceArea);
            this.gbArea.Controls.Add(this.lbNameArea);
            this.gbArea.Controls.Add(this.btnAddArea);
            this.gbArea.Location = new System.Drawing.Point(74, 131);
            this.gbArea.Name = "gbArea";
            this.gbArea.Size = new System.Drawing.Size(392, 250);
            this.gbArea.TabIndex = 22;
            this.gbArea.TabStop = false;
            // 
            // txtNameArea
            // 
            this.txtNameArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameArea.Location = new System.Drawing.Point(130, 47);
            this.txtNameArea.Name = "txtNameArea";
            this.txtNameArea.Size = new System.Drawing.Size(234, 26);
            this.txtNameArea.TabIndex = 18;
            // 
            // lbPriceArea
            // 
            this.lbPriceArea.AutoSize = true;
            this.lbPriceArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceArea.Location = new System.Drawing.Point(43, 100);
            this.lbPriceArea.Name = "lbPriceArea";
            this.lbPriceArea.Size = new System.Drawing.Size(52, 20);
            this.lbPriceArea.TabIndex = 21;
            this.lbPriceArea.Text = "Price :";
            // 
            // btnSaveArea
            // 
            this.btnSaveArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveArea.FlatAppearance.BorderSize = 0;
            this.btnSaveArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArea.ForeColor = System.Drawing.Color.White;
            this.btnSaveArea.Image = global::InternetCafe.Properties.Resources.Edit;
            this.btnSaveArea.Location = new System.Drawing.Point(222, 150);
            this.btnSaveArea.Name = "btnSaveArea";
            this.btnSaveArea.Size = new System.Drawing.Size(142, 51);
            this.btnSaveArea.TabIndex = 16;
            this.btnSaveArea.Text = "    Save";
            this.btnSaveArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveArea.UseVisualStyleBackColor = false;
            // 
            // txtPriceArea
            // 
            this.txtPriceArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceArea.Location = new System.Drawing.Point(130, 97);
            this.txtPriceArea.Name = "txtPriceArea";
            this.txtPriceArea.Size = new System.Drawing.Size(234, 26);
            this.txtPriceArea.TabIndex = 19;
            // 
            // lbNameArea
            // 
            this.lbNameArea.AutoSize = true;
            this.lbNameArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameArea.Location = new System.Drawing.Point(43, 50);
            this.lbNameArea.Name = "lbNameArea";
            this.lbNameArea.Size = new System.Drawing.Size(59, 20);
            this.lbNameArea.TabIndex = 20;
            this.lbNameArea.Text = "Name :";
            // 
            // btnAddArea
            // 
            this.btnAddArea.BackColor = System.Drawing.Color.Green;
            this.btnAddArea.FlatAppearance.BorderSize = 0;
            this.btnAddArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArea.ForeColor = System.Drawing.Color.White;
            this.btnAddArea.Image = global::InternetCafe.Properties.Resources.Add;
            this.btnAddArea.Location = new System.Drawing.Point(47, 150);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(142, 51);
            this.btnAddArea.TabIndex = 15;
            this.btnAddArea.Text = "    Create New";
            this.btnAddArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddArea.UseVisualStyleBackColor = false;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // btnDeleteArea
            // 
            this.btnDeleteArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteArea.FlatAppearance.BorderSize = 0;
            this.btnDeleteArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArea.ForeColor = System.Drawing.Color.White;
            this.btnDeleteArea.Image = global::InternetCafe.Properties.Resources.Delete;
            this.btnDeleteArea.Location = new System.Drawing.Point(500, 387);
            this.btnDeleteArea.Name = "btnDeleteArea";
            this.btnDeleteArea.Size = new System.Drawing.Size(142, 51);
            this.btnDeleteArea.TabIndex = 17;
            this.btnDeleteArea.Text = "    Delete";
            this.btnDeleteArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteArea.UseVisualStyleBackColor = false;
            // 
            // btnSearchArea
            // 
            this.btnSearchArea.BackColor = System.Drawing.Color.Gray;
            this.btnSearchArea.FlatAppearance.BorderSize = 0;
            this.btnSearchArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchArea.ForeColor = System.Drawing.Color.White;
            this.btnSearchArea.Image = global::InternetCafe.Properties.Resources.Search;
            this.btnSearchArea.Location = new System.Drawing.Point(937, 80);
            this.btnSearchArea.Name = "btnSearchArea";
            this.btnSearchArea.Size = new System.Drawing.Size(115, 29);
            this.btnSearchArea.TabIndex = 14;
            this.btnSearchArea.Text = "Search";
            this.btnSearchArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchArea.UseVisualStyleBackColor = false;
            // 
            // dgvArea
            // 
            this.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.area_id,
            this.area_name,
            this.area_price});
            this.dgvArea.Location = new System.Drawing.Point(500, 131);
            this.dgvArea.MultiSelect = false;
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(552, 250);
            this.dgvArea.TabIndex = 12;
            this.dgvArea.SelectionChanged += new System.EventHandler(this.dgvArea_SelectionChanged);
            // 
            // txtSearchArea
            // 
            this.txtSearchArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchArea.Location = new System.Drawing.Point(709, 80);
            this.txtSearchArea.Name = "txtSearchArea";
            this.txtSearchArea.Size = new System.Drawing.Size(222, 29);
            this.txtSearchArea.TabIndex = 13;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1099, 537);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Computer";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1099, 537);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(1099, 537);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "metroTabPage5";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // area_id
            // 
            this.area_id.DataPropertyName = "Entity_id";
            this.area_id.HeaderText = "Id";
            this.area_id.Name = "area_id";
            // 
            // area_name
            // 
            this.area_name.DataPropertyName = "Name";
            this.area_name.HeaderText = "Name";
            this.area_name.Name = "area_name";
            // 
            // area_price
            // 
            this.area_price.DataPropertyName = "Price";
            this.area_price.HeaderText = "Price";
            this.area_price.Name = "area_price";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 647);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.homeTabPage.ResumeLayout(false);
            this.areaTabPage.ResumeLayout(false);
            this.areaTabPage.PerformLayout();
            this.gbArea.ResumeLayout(false);
            this.gbArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnExit;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage homeTabPage;
        private MetroFramework.Controls.MetroTabPage areaTabPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private System.Windows.Forms.Label txtAdminName;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Button btnDeleteArea;
        private System.Windows.Forms.Button btnSaveArea;
        private System.Windows.Forms.Button btnSearchArea;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.TextBox txtSearchArea;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.GroupBox gbArea;
        private System.Windows.Forms.TextBox txtNameArea;
        private System.Windows.Forms.Label lbPriceArea;
        private System.Windows.Forms.TextBox txtPriceArea;
        private System.Windows.Forms.Label lbNameArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_price;
    }
}