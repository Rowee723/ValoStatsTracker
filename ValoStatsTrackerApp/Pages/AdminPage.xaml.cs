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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            player_stats Player = player_statsDA.GetPlayerStats(int.Parse(battleID.Text));

            if(Player != null)
            {
                RankPoints.Text = Player.RankPoints.ToString();
                RankPoints.Visibility = Visibility.Visible;
                RankPointsText.Visibility = Visibility.Visible;

                Kills.Text = Player.KillCount.ToString();
                Kills.Visibility = Visibility.Visible;
                KillsText.Visibility = Visibility.Visible;

                Deaths.Text = Player.DeathCount.ToString();
                Deaths.Visibility = Visibility.Visible;
                DeathText.Visibility = Visibility.Visible;
            }
        }
    }
}
