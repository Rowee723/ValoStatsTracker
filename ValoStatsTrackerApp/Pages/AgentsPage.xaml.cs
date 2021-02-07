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
using ValoStatsTrackerApp.Tables;

namespace ValoStatsTrackerApp
{
    /// <summary>
    /// Interaction logic for AgentsPage.xaml
    /// </summary>
    public partial class AgentsPage : Page
    {
        public AgentsPage()
        {
            InitializeComponent();
        }

        private void FindAgent(string name)
        {
            agents Agent = agentsDA.GetAgents(name);

            if (Agent != null)
            {
                agent_type.Text = Agent.AgentType;
                skill1_name.Text = Agent.FirstAbility;
                skill2_name.Text = Agent.SecondAbility;
                skill3_name.Text = Agent.ThirdAbility;
                ultimate_name.Text = Agent.UltimateAbility;

                skill1_cost.Text = Agent.FirstAbility_Cost.ToString();
                skill2_cost.Text = Agent.SecondAbilityCost.ToString();
                skill3_cost.Text = Agent.ThirdAbilityCharge_Method;
                ultimate_cost.Text = Agent.UltimateAbilityPoints.ToString() + " Points";
            }
            else
            {
                MessageBox.Show($"Invalid Agent! Try Again!");
            }
        }

        private void BreachButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Breach");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/BreachBG.png");
            BG.ImageSource = new BitmapImage(resource);

        }

        private void BrimstoneButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Brimstone");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/BrimstoneBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void CypherButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Cypher");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/CypherBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void JettButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Jett"); 
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/JettBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void OmenButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Omen");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/OmenBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void PhoenixButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Phoenix");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/PhoenixBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void RazeButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Raze");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/RazeBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void ReynaButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Reyna");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/ReynaBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void SageButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Sage");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/SageBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }

        private void SkyeButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Skye");
            Uri resource = new Uri("https://raw.githubusercontent.com/Rowee723/ValoStatsTracker/Roi/ValoStatsTrackerApp/Images/SkyeBG.png");
            BG.ImageSource = new BitmapImage(resource);
        }
    }
}
