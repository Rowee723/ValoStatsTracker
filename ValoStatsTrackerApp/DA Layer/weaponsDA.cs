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
            string query = "SELECT * FROM valorantdata.weapons WHERE name = (@WeaponName) limit 1";
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

                    string uMagazineSize = dr["magazine_size"].ToString();
                    int iMagazineSize = Int32.Parse(uMagazineSize);

                    string uEquipTime = dr["equip_time"].ToString();
                    double dEquipTime = Double.Parse(uEquipTime);

                    string uReloadTime = dr["reload_time"].ToString();
                    double dReloadTime = Double.Parse(uReloadTime);

                    string uWeaponCost = dr["cost"].ToString();
                    int iWeaponCost = Int32.Parse(uWeaponCost);

                    string uHeadshotDamage = dr["headshot_damage"].ToString();
                    int iHeadshotDamage = Int32.Parse(uHeadshotDamage);

                    string uTorsoDamage = dr["torso_damage"].ToString();
                    int iTorsoDamage = Int32.Parse(uTorsoDamage);

                    string uLegDamage = dr["leg_damage"].ToString();
                    int iLegDamage = Int32.Parse(uLegDamage);

                    aUser = new weapons(uWeaponName, uWeaponType, iMagazineSize, dEquipTime, dReloadTime, iWeaponCost, iHeadshotDamage, iTorsoDamage, iLegDamage);
                }
            }
            return aUser;
        }
    }
}
