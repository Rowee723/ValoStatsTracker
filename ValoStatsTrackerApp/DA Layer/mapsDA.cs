using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValoStatsTrackerApp.Helper;
using ValoStatsTrackerApp.Tables;

namespace ValoStatsTrackerApp.DA_Layer
{
    public static class mapsDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static maps GetMaps(string mapName)
        {
            string query = "SELECT * FROM maps WHERE name = (@MapName) limit 1";
            cmd = DBHelper.GetMapQuery(query, mapName);
            maps aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    string uMapName = dr["name"].ToString();

                    string uTotalMatches = dr["total_matches"].ToString();
                    int iTotalMatches = Int32.Parse(uTotalMatches);

                    string uAttackerWin = dr["attacker_win"].ToString();
                    int iAttackerWin = Int32.Parse(uAttackerWin);

                    string uDefenderWin = dr["defender_win"].ToString();
                    int iDefenderWin = Int32.Parse(uDefenderWin);



                    aUser = new maps(uMapName, iTotalMatches, iAttackerWin, iDefenderWin);
                }
            }
            return aUser;
        }
    }
}
