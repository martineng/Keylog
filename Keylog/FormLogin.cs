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
        }

        // Control to login
        private void txtboxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginAuthentication();
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

            if (BCrypt.Net.BCrypt.Verify(this.txtbUname.Text, uname))
            {
                if (BCrypt.Net.BCrypt.Verify(this.txtboxPwd.Text, pwd))
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
    } // END class
} // END namespace
