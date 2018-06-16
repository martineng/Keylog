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
    public partial class FormPanel : Form
    {
        Record locRecord;
        Record[] records;

        public FormPanel()
        {
            InitializeComponent();
        }

        public void OnLoad()
        {
            locRecord = new Record();
            records = new Record[9];

            /* TEST OBJECT */
            Record tempRecord = new Record("1", "FACEBOOK", "xxx@gmail.com","t**FB", "xxx@gmail.com");
            tempRecord = records[0];

            tempRecord = new Record("2", "GOOGLE", "xxx@gmail.com", "g**", "xxx@gmail.com");
            tempRecord = records[1];

            tempRecord = new Record("3", "DIGITAL OCEAN", "xxx@gmail.com", "t**DO", "xxx@gmail.com");
            tempRecord = records[2];
        } // END OnLoad()

        public Record Search(string inKeyword)
        {
            Record foundRec = new Record();
            Boolean isFound = false;

            for (int counter = 0; isFound != true || counter != 9; counter++)
            {
                if (tboxSearch.Text == records[counter].serviceName)
                {
                    foundRec = records[counter];
                    isFound = true;
                } // END IF
                else
                {
                    MessageBox.Show("No result match");
                } // END ELSE
            }

            return foundRec;
        }

    } // END CLASS FormPanel

    public class Record
    {
        public string id { get; private set; }
        public string serviceName { get; private set; }
        public string uname { get; private set; }
        public string pwd { get; private set; }
        public string email { get; private set; }

        public Record()
        {
            // DEFAULT
        } // END Record()

        public Record(string inId, string inServiceName, string inUname, string inPwd, string inEmail)
        {
            id = inId;
            serviceName = inServiceName;
            uname = inUname;
            pwd = inPwd;
            email = inEmail;
        } // END Record()
    } // END CLASS RECORD
}
