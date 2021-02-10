using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValoStatsTrackerApp.Helper;
using ValoStatsTrackerApp.PD_Layer;

namespace ValoStatsTrackerApp.DA_Layer
{
    public static class UsersDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static Users RetriveUser(string userID)
        {
            string query = "SELECT * FROM player_stats WHERE battle_tag = (@userID) limit 1";
            cmd = DBHelper.RunQuery(query, userID);
            Users aUser = null;
            if(cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    string uID = dr["battle_tag"].ToString();
                    string uName = dr["name"].ToString();
                    aUser = new Users(uID, uName);
                }
            }
            return aUser;
        }
    }
}
