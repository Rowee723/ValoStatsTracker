using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class player_stats
    {
        private string Battle_Tag; //Primary key
        private string name;
        private string Rank_Points;
        private string Kill_Count;
        private string Death_Count;
        private string KD_Ratio;
        private string Rank_Name;

        public player_stats(string battleTag, string name, string rankPoints, string killCount, string deathCount, string kdRatio, string rank)
        {
            BattleTag =  battleTag;
            Name = name;
            RankPoints = rankPoints;
            KillCount =  killCount;
            DeathCount = deathCount;
            KDRatio = kdRatio;
            RankName = rank;
        }

        public string BattleTag
        {
            get { return Battle_Tag; }
            set { Battle_Tag = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RankPoints
        {
            get { return Rank_Points;  }
            set { Rank_Points = value;  }
        }

        public string KillCount
        {
            get { return Kill_Count; }
            set { Kill_Count = value; }
        }

        public string DeathCount
        {
            get { return Death_Count; }
            set { Death_Count = value; }
        }

        public string KDRatio
        {
            get { return KD_Ratio; }
            set { KD_Ratio = value; }
        }

        public string RankName
        {
            get { return Rank_Name; }
            set { Rank_Name = value; }
        }
    }
}
