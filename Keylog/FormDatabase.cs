using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keylog
{
    public partial class FormDatabase : Form
    {
        DatabaseInfo theDatabase = new DatabaseInfo();

        public FormDatabase()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            theDatabase.ip = tboxIP.Text;
            theDatabase.username = tboxUsername.Text;
            theDatabase.password = tboxPassword.Text;
            this.Close();
        }
    }
}
