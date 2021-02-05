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
        private int Magazine_Size;
        private double Equip_Time;
        private double Reload_Time;
        private int Weapon_Cost;
        private int Headshot_Damage;
        private int Torso_Damage;
        private int Leg_Damage;

        public weapons(string weaponName, string weaponType, int magazineSize, double equipTime, double reloadTime,
                       int weaponCost, int headshotDamage, int torsoDamage, int legDamage)
        {
            WeaponName = weaponName;
            WeaponType = weaponType;
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

        public int MagazineSize
        {
            get { return Magazine_Size; }
            set { Magazine_Size = value; }
        }

        public double EquipTime
        {
            get { return Equip_Time; }
            set { Equip_Time = value; }
        }

        public double ReloadTime
        {
            get { return Reload_Time; }
            set { Reload_Time = value; }
        }
        public int WeaponCost
        {
            get { return Weapon_Cost; }
            set { Weapon_Cost = value; }
        }
        public int HeadshotDamage
        {
            get { return Headshot_Damage; }
            set { Headshot_Damage = value; }
        }
        public int TorsoDamage
        {
            get { return Torso_Damage; }
            set { Torso_Damage = value; }
        }
        public int LegDamage
        {
            get { return Leg_Damage; }
            set { Leg_Damage = value; }
        }
    }
}
