using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.PD_Layer
{
    public class Users
    {
        private string userID; //PK
        private string userName;

        public Users(string userID, string userName)
        {
            UserID = userID;
            UserName = userName;
        }
        
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}
