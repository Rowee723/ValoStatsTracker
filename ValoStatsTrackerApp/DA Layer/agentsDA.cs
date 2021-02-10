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
    public static class agentsDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static agents GetAgents(string agentName)
        {
            string query = "SELECT *, (first_ability_cost + second_ability_cost) AS total_ability_cost FROM agents WHERE name = (@AgentName) limit 1";
            cmd = DBHelper.GetAgentQuery(query, agentName);
            agents aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    string uAgentName = dr["name"].ToString();

                    string uAgentType = dr["type"].ToString();

                    string uFirstAbility = dr["first_ability"].ToString();

                    string uSecondAbility = dr["second_ability"].ToString();

                    string uThirdAbility = dr["third_ability"].ToString();

                    string uUltimateAbility = dr["ultimate_ability"].ToString();

                    string uFirstAbilityCost = dr["first_ability_cost"].ToString();

                    string uSecondAbilityCost = dr["second_ability_cost"].ToString();

                    string uTotalAbilityCost = dr["total_ability_cost"].ToString();

                    string uThirdAbilityChargeMethod = dr["third_ability_charge_method"].ToString();

                    string uUltimateAbilityPoints = dr["ultimate_ability_points"].ToString();
                    
                    aUser = new agents(uAgentName, uAgentType, uFirstAbility, uSecondAbility, uThirdAbility, uUltimateAbility, uFirstAbilityCost, uSecondAbilityCost, uTotalAbilityCost, uThirdAbilityChargeMethod, uUltimateAbilityPoints);
                }
            }
            return aUser;
        }
    }
}
