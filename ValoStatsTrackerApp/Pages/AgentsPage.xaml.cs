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
        }

        private void BrimstoneButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Brimstone");
        }

        private void CypherButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Cypher");
        }

        private void JettButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Jett");
        }

        private void OmenButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Omen");
        }

        private void PhoenixButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Phoenix");
        }

        private void RazeButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Raze");
        }

        private void ReynaButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Reyna");
        }

        private void SageButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Sage");
        }

        private void SkyeButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindAgent("Skye");
        }
    }
}
