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
    public static class player_statsDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static player_stats GetPlayerStats(int battleTag)
        {
            string query = "SELECT * FROM valorantdata.player_stats WHERE battle_tag = (@BattleTag) limit 1";
            cmd = DBHelper.GetPlayerQuery(query, battleTag);
            player_stats aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string uBattleTag = dr["battle_tag"].ToString();
                    int iBattleTag = Int32.Parse(uBattleTag);

                    string uName = dr["name"].ToString();

                    string uRankPoints = dr["rank_points"].ToString();
                    int iRankPoints = Int32.Parse(uRankPoints);

                    string uKillCount = dr["num_of_kills"].ToString();
                    int iKillCount = Int32.Parse(uKillCount);

                    string uDeathCount = dr["num_of_deaths"].ToString();
                    int iDeathCount = Int32.Parse(uDeathCount);


                    aUser = new player_stats(iBattleTag, uName, iRankPoints, iKillCount, iDeathCount);
                }
            }
            return aUser;
        }
    }
}
