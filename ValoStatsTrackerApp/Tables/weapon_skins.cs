using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class weapon_skins
    {
        private string Weapon_Skin_Name; //PK
        private string Is_Weapon_New;
        private string Is_Weapon_Available;
        private string Weapon_Skin_Price;
        private string Weapon_Skin_Set;

        public weapon_skins(string weaponSkinName, string isWeaponNew, string isWeaponAvailable, string weaponSkinPrice, string weaponSkinSet)
        {
            WeaponSkinName = weaponSkinName;
            IsWeaponNew = isWeaponNew;
            IsWeaponAvailable = isWeaponAvailable;
            WeaponSkinPrice = weaponSkinPrice;
            WeaponSkinSet = weaponSkinSet;
        }

        public string WeaponSkinName
        {
            get { return Weapon_Skin_Name; }
            set { Weapon_Skin_Name = value; }
        }

        public string IsWeaponNew
        {
            get { return Is_Weapon_New; }
            set { Is_Weapon_New = value; }
        }

        public string IsWeaponAvailable
        {
            get { return Is_Weapon_Available; }
            set { Is_Weapon_Available = value; }
        }

        public string WeaponSkinPrice
        {
            get { return Weapon_Skin_Price; }
            set { Weapon_Skin_Price = value; }
        }

        public string WeaponSkinSet
        {
            get { return Weapon_Skin_Set; }
            set { Weapon_Skin_Set = value; }
        }
    }
}
