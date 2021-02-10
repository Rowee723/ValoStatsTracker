using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class weapons
    {
        private string Weapon_Name; //PK
        private string Weapon_Type;
        private string Weapon_Classification;
        private string Magazine_Size;
        private string Equip_Time;
        private string Reload_Time;
        private string Weapon_Cost;
        private string Headshot_Damage;
        private string Torso_Damage;
        private string Leg_Damage;

        public weapons(string weaponName, string weaponType, string weaponClassification, string magazineSize, string equipTime, string reloadTime,
                       string weaponCost, string headshotDamage, string torsoDamage, string legDamage)
        {
            WeaponName = weaponName;
            WeaponType = weaponType;
            WeaponClassification = weaponClassification;
            MagazineSize = magazineSize;
            EquipTime = equipTime;
            ReloadTime = reloadTime;
            WeaponCost = weaponCost;
            HeadshotDamage = headshotDamage;
            TorsoDamage = torsoDamage;
            LegDamage = legDamage;
        }

        public string WeaponName
        {
            get { return Weapon_Name; }
            set { Weapon_Name = value; }
        }

        public string WeaponType
        {
            get { return Weapon_Type; }
            set { Weapon_Type = value; }
        }

        public string WeaponClassification
        {
            get { return Weapon_Classification; }
            set { Weapon_Classification = value; }
        }

        public string MagazineSize
        {
            get { return Magazine_Size; }
            set { Magazine_Size = value; }
        }

        public string EquipTime
        {
            get { return Equip_Time; }
            set { Equip_Time = value; }
        }

        public string ReloadTime
        {
            get { return Reload_Time; }
            set { Reload_Time = value; }
        }
        public string WeaponCost
        {
            get { return Weapon_Cost; }
            set { Weapon_Cost = value; }
        }
        public string HeadshotDamage
        {
            get { return Headshot_Damage; }
            set { Headshot_Damage = value; }
        }
        public string TorsoDamage
        {
            get { return Torso_Damage; }
            set { Torso_Damage = value; }
        }
        public string LegDamage
        {
            get { return Leg_Damage; }
            set { Leg_Damage = value; }
        }
    }
}
