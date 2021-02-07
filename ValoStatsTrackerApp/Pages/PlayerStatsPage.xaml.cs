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
        public PlayerStatsPage()
        {
            InitializeComponent();
        }
        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            string playerID = UsernameText.Text;

            if (!string.IsNullOrEmpty(playerID))
            {
                player_stats PStats = player_statsDA.GetPlayerStats(int.Parse(playerID));
                if (PStats != null)
                {
                    PlayerName.Text = PStats.Name;
                    PlayerTag.Text = playerID;
                    RankPoints.Text = PStats.RankPoints.ToString();
                    Kills.Text = PStats.KillCount.ToString();
                    Deaths.Text = PStats.DeathCount.ToString();
                }
                else
                {
                    MessageBox.Show($"Invalid Player Tag! Try Again!");
                }
            }
        }
    }
}
