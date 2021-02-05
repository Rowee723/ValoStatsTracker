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
    public static class weapon_skinsDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static weapon_skins GetWeaponSkins(string weaponSkinName)
        {
            string query = "SELECT * FROM valorantdata.weapon_skins WHERE name = (@WeaponSkinName) limit 1";
            cmd = DBHelper.GetWeaponSkinQuery(query, weaponSkinName);
            weapon_skins aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string uWeaponSkinName = dr["name"].ToString();

                    string uIsWeaponNew = dr["is_New"].ToString();
                    bool bIsWeaponNew = Boolean.Parse(uIsWeaponNew);

                    string uIsWeaponAvailable = dr["is_Available"].ToString();
                    bool bIsWeaponAvailable = Boolean.Parse(uIsWeaponAvailable);

                    string uWeaponSkinPrice = dr["price"].ToString();
                    int iWeaponSkinPrice = Int32.Parse(uWeaponSkinPrice);

                    string uWeaponSkinSet = dr["collection_set"].ToString();

                    aUser = new weapon_skins(uWeaponSkinName, bIsWeaponNew, bIsWeaponAvailable, iWeaponSkinPrice, uWeaponSkinSet);
                }
            }
            return aUser;
        }
    }
}
