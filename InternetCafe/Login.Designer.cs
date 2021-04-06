
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbForm = new System.Windows.Forms.PictureBox();
            this.linkFindPass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(113, 283);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(113, 237);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(158, 22);
            this.txtUser.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
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
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.White;
            this.pbPassword.Image = global::InternetCafe.Properties.Resources.lock_outlined_padlock_symbol_for_security_interface_icon_icons_com_57803;
            this.pbPassword.Location = new System.Drawing.Point(76, 283);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(22, 22);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 5;
            this.pbPassword.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.White;
            this.pbUser.Image = global::InternetCafe.Properties.Resources.Gender_Neutral_User_icon_icons_com_55902;
            this.pbUser.Location = new System.Drawing.Point(76, 237);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(22, 22);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // pbForm
            // 
            this.pbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbForm.Image = global::InternetCafe.Properties.Resources._7e12b6838e5cbdcafeab842555e4dec1;
            this.pbForm.Location = new System.Drawing.Point(0, 0);
            this.pbForm.Name = "pbForm";
            this.pbForm.Size = new System.Drawing.Size(337, 599);
            this.pbForm.TabIndex = 0;
            this.pbForm.TabStop = false;
            // 
            // linkFindPass
            // 
            this.linkFindPass.AutoSize = true;
            this.linkFindPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFindPass.LinkColor = System.Drawing.Color.Black;
            this.linkFindPass.Location = new System.Drawing.Point(114, 373);
            this.linkFindPass.Name = "linkFindPass";
            this.linkFindPass.Size = new System.Drawing.Size(119, 16);
            this.linkFindPass.TabIndex = 3;
            this.linkFindPass.TabStop = true;
            this.linkFindPass.Text = "Forgot password ?";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 599);
            this.Controls.Add(this.linkFindPass);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbForm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.LinkLabel linkFindPass;
    }
}

