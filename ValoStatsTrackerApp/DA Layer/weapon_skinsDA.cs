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
            string query = "SELECT name, IF(is_New = 0, 'Old', 'New') AS status, IF(is_Available = 1, 'Purchasable', 'Not Purchasable') AS availability, collection_set AS collection, price FROM weapon_skins WHERE name = (@WeaponSkinName) limit 1";
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

                    string uIsWeaponNew = dr["status"].ToString();

                    string uIsWeaponAvailable = dr["availability"].ToString();

                    string uWeaponSkinPrice = dr["price"].ToString();

                    string uWeaponSkinSet = dr["collection"].ToString();

                    aUser = new weapon_skins(uWeaponSkinName, uIsWeaponNew, uIsWeaponAvailable, uWeaponSkinPrice, uWeaponSkinSet);
                }
            }
            return aUser;
        }
    }
}
