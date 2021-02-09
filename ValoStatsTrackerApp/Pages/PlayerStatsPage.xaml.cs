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

namespace ValoStatsTrackerApp.Pages
{
    /// <summary>
    /// Interaction logic for PlayerStatsPage.xaml
    /// </summary>
    public partial class PlayerStatsPage : Page
    {
        bool admin = false;
        public PlayerStatsPage(bool hasAdminAccess)
        {
            InitializeComponent();
            admin = hasAdminAccess;
        }
        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            string playerID = UsernameText.Text;

            if (!string.IsNullOrEmpty(playerID))
            {
                int temp;
                if (int.TryParse(playerID, out temp))
                {
                    player_stats PStats = player_statsDA.GetPlayerStats(int.Parse(playerID));

                    if (PStats != null)
                    {

                        rp.Text = "Rank Points: ";
                        tk.Text = "Total Kills:";
                        td.Text = "Total Deaths: ";

                        PlayerName.Text = PStats.Name;
                        PlayerTag.Text = "#" + playerID;
                        RankPoints.Text = PStats.RankPoints.ToString();
                        Kills.Text = PStats.KillCount.ToString();
                        Deaths.Text = PStats.DeathCount.ToString();

                        if (admin)
                        {
                            RankPoints_Updated.Visibility = Visibility.Visible;
                            Kills_Updated.Visibility = Visibility.Visible;
                            Deaths_Updated.Visibility = Visibility.Visible;
                            UpdateButton.Visibility = Visibility.Visible;

                            RankPoints_Updated.Text = PStats.RankPoints.ToString();
                            Kills_Updated.Text = PStats.KillCount.ToString();
                            Deaths_Updated.Text = PStats.DeathCount.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Battle Tag! Try Again!");
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid Battle Tag! Try Again!");
                }
            }
        }

        private void UpdateButton_OnClick(object sender, RoutedEventArgs e)
        {
            string playerID = UsernameText.Text;
            string rankPoints = RankPoints_Updated.Text;
            string kills = Kills_Updated.Text;
            string deaths = Deaths_Updated.Text;

            if (admin)
            {
                if (!string.IsNullOrEmpty(playerID))
                {
                    int temp;
                    if (int.TryParse(playerID, out temp))
                    {
                        player_statsDA.UpdatePlayerStats(int.Parse(playerID), int.Parse(rankPoints), int.Parse(kills), int.Parse(deaths));
                        
                        player_stats PStats = player_statsDA.GetPlayerStats(int.Parse(playerID));

                        if (PStats != null)
                        {
                            MessageBox.Show("You updated " + PStats.Name, "Updated player", MessageBoxButton.OK);

                            RankPoints.Text = PStats.RankPoints.ToString();
                            Kills.Text = PStats.KillCount.ToString();
                            Deaths.Text = PStats.DeathCount.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Invalid Battle Tag! Try Again!");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Battle Tag! Try Again!");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Access denied");
            }

        }
    }
}
