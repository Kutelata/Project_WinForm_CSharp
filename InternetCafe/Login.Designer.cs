
namespace InternetCafe
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkFindPass = new System.Windows.Forms.LinkLabel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbForm = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.passValidate = new InternetCafe.myValidate();
            this.loginValidate = new InternetCafe.myValidate();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(113, 329);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkFindPass
            // 
            this.linkFindPass.AutoSize = true;
            this.linkFindPass.BackColor = System.Drawing.Color.Black;
            this.linkFindPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFindPass.LinkColor = System.Drawing.Color.White;
            this.linkFindPass.Location = new System.Drawing.Point(114, 373);
            this.linkFindPass.Name = "linkFindPass";
            this.linkFindPass.Size = new System.Drawing.Size(119, 16);
            this.linkFindPass.TabIndex = 3;
            this.linkFindPass.TabStop = true;
            this.linkFindPass.Text = "Forgot password ?";
            this.linkFindPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFindPass_LinkClicked);
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.Black;
            this.pbPassword.Image = global::InternetCafe.Properties.Resources.Password;
            this.pbPassword.Location = new System.Drawing.Point(76, 283);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(22, 18);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 5;
            this.pbPassword.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.Black;
            this.pbUser.Image = global::InternetCafe.Properties.Resources.User;
            this.pbUser.Location = new System.Drawing.Point(76, 237);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(22, 18);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // pbForm
            // 
            this.pbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbForm.Image = ((System.Drawing.Image)(resources.GetObject("pbForm.Image")));
            this.pbForm.Location = new System.Drawing.Point(0, 0);
            this.pbForm.Name = "pbForm";
            this.pbForm.Size = new System.Drawing.Size(337, 599);
            this.pbForm.TabIndex = 0;
            this.pbForm.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(294, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 26);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // passValidate
            // 
            this.passValidate.BackColor = System.Drawing.Color.Black;
            this.passValidate.changeCharacter = '*';
            this.passValidate.FieldName = "Password";
            this.passValidate.Location = new System.Drawing.Point(104, 283);
            this.passValidate.myTextBox = null;
            this.passValidate.Name = "passValidate";
            this.passValidate.Pattern = "^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$";
            this.passValidate.Size = new System.Drawing.Size(233, 43);
            this.passValidate.TabIndex = 7;
            // 
            // loginValidate
            // 
            this.loginValidate.BackColor = System.Drawing.Color.Black;
            this.loginValidate.changeCharacter = '\0';
            this.loginValidate.FieldName = "UserName";
            this.loginValidate.Location = new System.Drawing.Point(104, 237);
            this.loginValidate.myTextBox = null;
            this.loginValidate.Name = "loginValidate";
            this.loginValidate.Pattern = "^[a-z]([-\']?[a-z]+)*( [a-z]([-\']?[a-z]+)*)+$";
            this.loginValidate.Size = new System.Drawing.Size(233, 43);
            this.loginValidate.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(337, 599);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.passValidate);
            this.Controls.Add(this.loginValidate);
            this.Controls.Add(this.linkFindPass);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbForm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.LinkLabel linkFindPass;
        private myValidate loginValidate;
        private myValidate passValidate;
        private System.Windows.Forms.Button btnExit;
    }
}

