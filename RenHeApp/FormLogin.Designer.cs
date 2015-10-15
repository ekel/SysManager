namespace RenHeApp
{
    partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.labUser = new System.Windows.Forms.Label();
			this.labPwd = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(105, 58);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(100, 21);
			this.txtUser.TabIndex = 0;
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(105, 120);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(100, 21);
			this.txtPwd.TabIndex = 1;
			// 
			// labUser
			// 
			this.labUser.AutoSize = true;
			this.labUser.Location = new System.Drawing.Point(58, 61);
			this.labUser.Name = "labUser";
			this.labUser.Size = new System.Drawing.Size(41, 12);
			this.labUser.TabIndex = 2;
			this.labUser.Text = "用户名";
			// 
			// labPwd
			// 
			this.labPwd.AutoSize = true;
			this.labPwd.Location = new System.Drawing.Point(60, 120);
			this.labPwd.Name = "labPwd";
			this.labPwd.Size = new System.Drawing.Size(29, 12);
			this.labPwd.TabIndex = 3;
			this.labPwd.Text = "密码";
			// 
			// btnLogin
			// 
			this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnLogin.Location = new System.Drawing.Point(62, 174);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 25);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "登录";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(192, 174);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 25);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 215);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.labPwd);
			this.Controls.Add(this.labUser);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtUser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}