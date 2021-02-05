using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class player_stats
    {
        private int Battle_Tag; //Primary key
        private string name;
        private int Rank_Points;
        private int Kill_Count;
        private int Death_Count;

        public player_stats(int battleTag, string name, int rankPoints, int killCount, int deathCount)
        {
            BattleTag =  battleTag;
            Name = name;
            RankPoints = rankPoints;
            KillCount =  killCount;
            DeathCount = deathCount;
        }

        public int BattleTag
        {
            get { return Battle_Tag; }
            set { Battle_Tag = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int RankPoints
        {
            get { return Rank_Points;  }
            set { Rank_Points = value;  }
        }

        public int KillCount
        {
            get { return Kill_Count; }
            set { Kill_Count = value; }
        }

        public int DeathCount
        {
            get { return Death_Count; }
            set { Death_Count = value; }
        }
    }
}
