
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtAdminName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.homeTabPage = new MetroFramework.Controls.MetroTabPage();
            this.areaTabPage = new MetroFramework.Controls.MetroTabPage();
            this.gbArea = new System.Windows.Forms.GroupBox();
            this.txtNameArea = new System.Windows.Forms.TextBox();
            this.lbPriceArea = new System.Windows.Forms.Label();
            this.txtPriceArea = new System.Windows.Forms.TextBox();
            this.lbNameArea = new System.Windows.Forms.Label();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.area_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchArea = new System.Windows.Forms.TextBox();
            this.computerTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.btnSaveArea = new System.Windows.Forms.Button();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.btnDeleteArea = new System.Windows.Forms.Button();
            this.btnSearchArea = new System.Windows.Forms.Button();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.areaTabPage.SuspendLayout();
            this.gbArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mainTabControl.Controls.Add(this.computerTabPage);
            this.mainTabControl.Controls.Add(this.metroTabPage4);
            this.mainTabControl.Controls.Add(this.metroTabPage5);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 68);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1107, 579);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.UseSelectable = true;
            // 
            // homeTabPage
            // 
            this.homeTabPage.Controls.Add(this.groupBox1);
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
            // areaTabPage
            // 
            this.areaTabPage.Controls.Add(this.gbArea);
            this.areaTabPage.Controls.Add(this.dgvArea);
            this.areaTabPage.Controls.Add(this.txtSearchArea);
            this.areaTabPage.Controls.Add(this.btnDeleteArea);
            this.areaTabPage.Controls.Add(this.btnSearchArea);
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
            // dgvArea
            // 
            this.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArea.BackgroundColor = System.Drawing.Color.White;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.area_id,
            this.area_name,
            this.area_price});
            this.dgvArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArea.Location = new System.Drawing.Point(500, 131);
            this.dgvArea.MultiSelect = false;
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(552, 250);
            this.dgvArea.TabIndex = 12;
            this.dgvArea.SelectionChanged += new System.EventHandler(this.dgvArea_SelectionChanged);
            // 
            // area_id
            // 
            this.area_id.DataPropertyName = "Entity_id";
            this.area_id.HeaderText = "Id";
            this.area_id.Name = "area_id";
            this.area_id.ReadOnly = true;
            // 
            // area_name
            // 
            this.area_name.DataPropertyName = "Name";
            this.area_name.HeaderText = "Name";
            this.area_name.Name = "area_name";
            this.area_name.ReadOnly = true;
            // 
            // area_price
            // 
            this.area_price.DataPropertyName = "Price";
            this.area_price.HeaderText = "Price";
            this.area_price.Name = "area_price";
            this.area_price.ReadOnly = true;
            // 
            // txtSearchArea
            // 
            this.txtSearchArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchArea.Location = new System.Drawing.Point(709, 80);
            this.txtSearchArea.Name = "txtSearchArea";
            this.txtSearchArea.Size = new System.Drawing.Size(222, 29);
            this.txtSearchArea.TabIndex = 13;
            // 
            // computerTabPage
            // 
            this.computerTabPage.HorizontalScrollbarBarColor = true;
            this.computerTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.computerTabPage.HorizontalScrollbarSize = 10;
            this.computerTabPage.Location = new System.Drawing.Point(4, 38);
            this.computerTabPage.Name = "computerTabPage";
            this.computerTabPage.Size = new System.Drawing.Size(1099, 537);
            this.computerTabPage.TabIndex = 2;
            this.computerTabPage.Text = "Computer";
            this.computerTabPage.VerticalScrollbarBarColor = true;
            this.computerTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.computerTabPage.VerticalScrollbarSize = 10;
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
            this.btnSaveArea.Click += new System.EventHandler(this.btnSaveArea_Click);
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
            this.btnDeleteArea.Click += new System.EventHandler(this.btnDeleteArea_Click);
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
            this.btnSearchArea.Click += new System.EventHandler(this.btnSearchArea_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 464);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InternetCafe.Properties.Resources.CircleProgress;
            this.pictureBox3.Location = new System.Drawing.Point(644, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(352, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InternetCafe.Properties.Resources.ProgressBar;
            this.pictureBox2.Location = new System.Drawing.Point(644, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = "c.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "a.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "b.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usage Overview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Weekly Statistics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            this.mainTabControl.ResumeLayout(false);
            this.homeTabPage.ResumeLayout(false);
            this.areaTabPage.ResumeLayout(false);
            this.areaTabPage.PerformLayout();
            this.gbArea.ResumeLayout(false);
            this.gbArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnExit;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage homeTabPage;
        private MetroFramework.Controls.MetroTabPage areaTabPage;
        private MetroFramework.Controls.MetroTabPage computerTabPage;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn area_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}