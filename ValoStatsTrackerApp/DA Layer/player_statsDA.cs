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
            string query = "SELECT battle_tag, name, rank_points, num_of_kills, num_of_deaths, (num_of_kills/num_of_deaths) AS KD_ratio, CASE WHEN rank_points >= 800 THEN 'Radiant' WHEN rank_points >= 700 THEN 'Immortal' WHEN rank_points >= 600 THEN 'Diamond' WHEN rank_points >= 500 THEN 'Platinum' WHEN rank_points >= 400 THEN 'Gold' WHEN rank_points >= 300 THEN 'Silver' WHEN rank_points >= 200 THEN 'Bronze' WHEN rank_points >= 100 THEN 'Iron' ELSE 'Unranked' END AS rank_name FROM player_stats WHERE battle_tag = (@BattleTag) limit 1";
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

                    string uName = dr["name"].ToString();

                    string uRankPoints = dr["rank_points"].ToString();

                    string uKillCount = dr["num_of_kills"].ToString();

                    string uDeathCount = dr["num_of_deaths"].ToString();

                    string uKDRatio = dr["KD_ratio"].ToString();

                    string uRank = dr["rank_name"].ToString();


                    aUser = new player_stats(uBattleTag, uName, uRankPoints, uKillCount, uDeathCount, uKDRatio, uRank);
                }
            }
            return aUser;
        }

        public static void UpdatePlayerStats(int battleTag, int rankPoints, int kills, int deaths)
        {
            string query = "BEGIN; UPDATE valorantdata.player_stats SET rank_points = (@RankPoints), num_of_kills = (@Kills), num_of_deaths = (@Deaths) WHERE battle_tag = (@BattleTag); COMMIT;";
            cmd = DBHelper.UpdatePlayerStats(query, battleTag, rankPoints, kills, deaths);
        }
    }
}
