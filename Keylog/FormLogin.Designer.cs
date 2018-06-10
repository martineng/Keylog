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
            this.txtbUname = new System.Windows.Forms.TextBox();
            this.txtboxPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbUname
            // 
            this.txtbUname.Location = new System.Drawing.Point(100, 50);
            this.txtbUname.MaxLength = 255;
            this.txtbUname.Name = "txtbUname";
            this.txtbUname.Size = new System.Drawing.Size(200, 20);
            this.txtbUname.TabIndex = 0;
            // 
            // txtboxPwd
            // 
            this.txtboxPwd.Location = new System.Drawing.Point(100, 100);
            this.txtboxPwd.MaxLength = 255;
            this.txtboxPwd.Name = "txtboxPwd";
            this.txtboxPwd.PasswordChar = '*';
            this.txtboxPwd.ShortcutsEnabled = false;
            this.txtboxPwd.Size = new System.Drawing.Size(200, 20);
            this.txtboxPwd.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.txtboxPwd);
            this.Controls.Add(this.txtbUname);
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

        private System.Windows.Forms.TextBox txtbUname;
        private System.Windows.Forms.TextBox txtboxPwd;
    }
}

