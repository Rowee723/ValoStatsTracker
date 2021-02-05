using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class maps
    {
        private string Map_Name; //PK
        private int Total_Matches;
        private int Attacker_Win;
        private int Defender_Win;

        public maps(string mapName, int totalMatches, int attackerWin, int defenderWin)
        {
            MapName = mapName;
            TotalMatches = totalMatches;
            AttackerWin = attackerWin;
            DefenderWin = defenderWin;
        }

        public string MapName
        {
            get { return Map_Name; }
            set { Map_Name = value; }
        }

        public int TotalMatches
        {
            get { return Total_Matches; }
            set { Total_Matches = value; }
        }

        public int AttackerWin
        {
            get { return Attacker_Win; }
            set { Attacker_Win = value; }
        }

        public int DefenderWin
        {
            get { return Defender_Win; }
            set { Defender_Win = value; }
        }
    }
}
