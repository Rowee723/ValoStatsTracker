using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class agents
    {
        private string Agent_Name; //PK
        private string Agent_Type;
        private string First_Ability;
        private string Second_Ability;
        private string Third_Ability;
        private string Ultimate_Ability;
        private int First_Ability_Cost;
        private int Second_Ability_Cost;
        private string Third_Ability_Charge_Method;
        private int Ultimate_Ability_Points;

        public agents(string agentName, string agentType, string firstAbility, string secondAbility, string thirdAbility, string ultimateAbility, 
                      int firstAbilityCost, int secondAbilityCost, string thirdAbilityChargeMethod, int ultimateAbilityPoints)
        {
            AgentName = agentName;
            AgentType = agentType;
            FirstAbility = firstAbility;
            SecondAbility = secondAbility;
            ThirdAbility = thirdAbility;
            UltimateAbility = ultimateAbility;
            FirstAbility_Cost = firstAbilityCost;
            SecondAbilityCost = secondAbilityCost;
            ThirdAbilityCharge_Method = thirdAbilityChargeMethod;
            UltimateAbilityPoints = ultimateAbilityPoints;
        }

        public string AgentName
        {
            get { return Agent_Name; }
            set { Agent_Name = value; }
        }

        public string AgentType
        {
            get { return Agent_Type; }
            set { Agent_Type = value; }
        }

        public string FirstAbility
        {
            get { return First_Ability; }
            set { First_Ability = value; }
        }

        public string SecondAbility
        {
            get { return Second_Ability; }
            set { Second_Ability = value; }
        }

        public string ThirdAbility
        {
            get { return Third_Ability; }
            set { Third_Ability = value; }
        }

        public string UltimateAbility
        {
            get { return Ultimate_Ability; }
            set { Ultimate_Ability = value; }
        }

        public int FirstAbility_Cost
        {
            get { return First_Ability_Cost; }
            set { First_Ability_Cost = value; }
        }

        public int SecondAbilityCost
        {
            get { return Second_Ability_Cost; }
            set { Second_Ability_Cost = value; }
        }

        public string ThirdAbilityCharge_Method
        {
            get { return Third_Ability_Charge_Method; }
            set { Third_Ability_Charge_Method = value; }
        }

        public int UltimateAbilityPoints
        {
            get { return Ultimate_Ability_Points; }
            set { Ultimate_Ability_Points = value; }
        }

    }
}
