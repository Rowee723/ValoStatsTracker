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
    public static class weaponsDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static weapons GetWeapons(string weaponName)
        {
            string query = "SELECT name, CASE type WHEN 'Assault Rifles' THEN 'Primary' WHEN 'Sidearms' THEN 'Secondary' WHEN 'Sniper Rifles' THEN 'Primary' WHEN 'Shotguns' THEN 'Primary' WHEN 'Heavy Weapons' THEN 'Primary' WHEN 'SMGs' THEN 'Primary' ELSE 'NaN' END AS type,  type AS classification, magazine_size, equip_time, reload_time, cost, headshot_damage, torso_damage, leg_damage FROM weapons WHERE name = (@WeaponName) limit 1";
            cmd = DBHelper.GetWeaponQuery(query, weaponName);
            weapons aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    string uWeaponName = dr["name"].ToString();

                    string uWeaponType = dr["type"].ToString();

                    string uWeaponClassification = dr["classification"].ToString();

                    string uMagazineSize = dr["magazine_size"].ToString();

                    string uEquipTime = dr["equip_time"].ToString();

                    string uReloadTime = dr["reload_time"].ToString();

                    string uWeaponCost = dr["cost"].ToString();

                    string uHeadshotDamage = dr["headshot_damage"].ToString();

                    string uTorsoDamage = dr["torso_damage"].ToString();

                    string uLegDamage = dr["leg_damage"].ToString();

                    aUser = new weapons(uWeaponName, uWeaponType, uWeaponClassification, uMagazineSize, uEquipTime, uReloadTime, uWeaponCost, uHeadshotDamage, uTorsoDamage, uLegDamage);
                }
            }
            return aUser;
        }
    }
}
