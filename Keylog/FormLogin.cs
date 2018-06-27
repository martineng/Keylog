using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BCrypt.Net;

namespace KeyLog
{
    public partial class FormLogin : Form
    {
        // Test Object
        string uname = "martineng";
        string pwd = "password";
        
        public FormLogin()
        {
            InitializeComponent();
            OnLoad();
            tboxUname_Leave(this, new EventArgs());
            tboxPwd_Leave(this, new EventArgs());
        }

        // Control to login
        private void txtboxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        // Action on load
        public void OnLoad()
        {
            // Encrypting User
            uname = BCrypt.Net.BCrypt.HashString(uname);
            pwd = BCrypt.Net.BCrypt.HashPassword(pwd);
        }

        // To validate User
        public Boolean loginAuthentication()
        {
            Boolean isMatch = false; // Validate if it's User

            if (BCrypt.Net.BCrypt.Verify(this.tboxUname.Text, uname))
            {
                if (BCrypt.Net.BCrypt.Verify(this.tboxPwd.Text, pwd))
                {
                    isMatch = true;
                    MessageBox.Show("WELCOME");
                } // END IF
                else
                {
                    isMatch = false;
                    MessageBox.Show("INVALID CREDENTIAL");
                } // END ELSE
            } // END IF
            else
            {
                isMatch = false;
                MessageBox.Show("INVALID CREDENTIAL");
            } // END ELSE

            return isMatch;
        } // END validateUser()

        // Watermark effect for textboxes
        private void tboxUname_Enter(object sender, EventArgs e)
        {
            if (tboxUname.Text == "Username")
            {
                tboxUname.Text = "";
                tboxUname.ForeColor = SystemColors.WindowText;
                tboxUname.UseSystemPasswordChar = true;
            }
        }

        private void tboxUname_Leave(object sender, EventArgs e)
        {
            if (tboxUname.Text.Length == 0)
            {
                tboxUname.Text = "Username";
                tboxUname.ForeColor = SystemColors.GrayText;
                tboxUname.UseSystemPasswordChar = false;
            }
        }

        private void tboxPwd_Enter(object sender, EventArgs e)
        {
            if (tboxPwd.Text == "Password")
            {
                tboxPwd.Text = "";
                tboxPwd.ForeColor = SystemColors.WindowText;
                tboxPwd.UseSystemPasswordChar = true;
            }
        }

        private void tboxPwd_Leave(object sender, EventArgs e)
        {
            if (tboxPwd.Text.Length == 0)
            {
                tboxPwd.Text = "Password";
                tboxPwd.ForeColor = SystemColors.GrayText;
                tboxPwd.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginAuthentication())
            {
                this.Hide();
                Keylog.FormPanel formPanel = new Keylog.FormPanel();
                formPanel.Closed += (s, arg) => this.Close();
                formPanel.Show();
            }
        }
    } // END class
} // END namespace
