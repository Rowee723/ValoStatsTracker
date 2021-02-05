using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValoStatsTrackerApp.DA_Layer;
using ValoStatsTrackerApp.Helper;
using ValoStatsTrackerApp.PD_Layer;
using ValoStatsTrackerApp.Tables;

namespace ValoStatsTrackerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {UsernameText.Text}");
        }

        private void GetUserButton_Click(object sender, RoutedEventArgs e)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            // User Message Box
            string userID = UsernameText.Text;

            //Users aUser = UsersDA.RetriveUser(userID);
            // MessageBox.Show($"Welcome {aUser.UserName}");
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // outputs Player Stats table query
            string battleTag = UsernameText.Text;
            int iBattleTag = Int32.Parse(battleTag);

            //player_stats aPlayer = player_statsDA.GetPlayerStats(iBattleTag);
            //MessageBox.Show($" Name: {aPlayer.Name} \n Rank Points: {aPlayer.RankPoints} \n Kill Count: {aPlayer.KillCount} \n Death Count: {aPlayer.DeathCount}");
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* 
            // outputs agents table query
            string agentName = UsernameText.Text;
            agents aAgent = agentsDA.GetAgents(agentName);
            if (aAgent != null) {
                MessageBox.Show($" Agent Name: {aAgent.AgentName} \n Agent Type: {aAgent.AgentType} \n First Ability: {aAgent.FirstAbility} \n Second Ability: {aAgent.SecondAbility} \n " +
                            $"Second Ability: {aAgent.ThirdAbility} \n Ultimate Ability: {aAgent.UltimateAbility} \n First Ability Cost: {aAgent.FirstAbility_Cost} " +
                            $"\n Second Ability Cost: {aAgent.SecondAbilityCost} \n Third Ability Recharge Method: {aAgent.ThirdAbilityCharge_Method} \n Ultimate Ability Points: {aAgent.UltimateAbilityPoints}");
            }

            else {
                MessageBox.Show($"Invalid Agent Name! Try Again!");
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            /*
            // outputs map table query
            string mapName = UsernameText.Text;
            maps aMap = mapsDA.GetMaps(mapName);
            if (aMap != null) {
                MessageBox.Show($" Map Name: {aMap.MapName} \n Total Matches: {aMap.TotalMatches} \n Attackers Win: {aMap.AttackerWin} \n Defenders Win: {aMap.DefenderWin}");
            }

            else {
                MessageBox.Show($"Invalid Map Name! Try Again!");
            }
            */




        }
    }
}
