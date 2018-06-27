using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keylog
{
    class DatabaseInfo
    {
        public string ip { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool isConnected { get; set; }

        public DatabaseInfo()
        {
            // DEFAULT
        } // END Database()

        public DatabaseInfo(string inIp, string inUsername, string inPassword)
        {
            ip = inIp;
            username = inUsername;
            password = inPassword;
        } // END Database()
    }
}
