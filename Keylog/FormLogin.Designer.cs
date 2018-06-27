namespace KeyLog
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
            this.tboxUname = new System.Windows.Forms.TextBox();
            this.tboxPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxUname
            // 
            this.tboxUname.Location = new System.Drawing.Point(100, 25);
            this.tboxUname.MaxLength = 255;
            this.tboxUname.Name = "tboxUname";
            this.tboxUname.ShortcutsEnabled = false;
            this.tboxUname.Size = new System.Drawing.Size(200, 20);
            this.tboxUname.TabIndex = 1;
            this.tboxUname.UseSystemPasswordChar = true;
            this.tboxUname.Enter += new System.EventHandler(this.tboxUname_Enter);
            this.tboxUname.Leave += new System.EventHandler(this.tboxUname_Leave);
            // 
            // tboxPwd
            // 
            this.tboxPwd.Location = new System.Drawing.Point(100, 70);
            this.tboxPwd.MaxLength = 255;
            this.tboxPwd.Name = "tboxPwd";
            this.tboxPwd.ShortcutsEnabled = false;
            this.tboxPwd.Size = new System.Drawing.Size(200, 20);
            this.tboxPwd.TabIndex = 2;
            this.tboxPwd.UseSystemPasswordChar = true;
            this.tboxPwd.Enter += new System.EventHandler(this.tboxPwd_Enter);
            this.tboxPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxPwd_KeyDown);
            this.tboxPwd.Leave += new System.EventHandler(this.tboxPwd_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(150, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 136);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tboxPwd);
            this.Controls.Add(this.tboxUname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUname;
        private System.Windows.Forms.TextBox tboxPwd;
        private System.Windows.Forms.Button btnLogin;
    }
}

