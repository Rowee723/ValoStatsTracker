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
    /// Interaction logic for MapsPage.xaml
    /// </summary>
    public partial class MapsPage : Page
    {
        public MapsPage()
        {
            InitializeComponent();
        }

        private void FindMap(string name)
        {
            maps Map = mapsDA.GetMaps(name);

            if (Map != null)
            {
                tm_name.Text = "Total Matches: ";
                wr.Text = "Win Rate: ";
                lr.Text = "Lose Rate: ";


                map_name.Text = name;
                total_matches.Text = Map.TotalMatches.ToString();
                num_of_wins.Text = Math.Round(((Convert.ToDouble(Map.AttackerWin) / Convert.ToDouble(Map.TotalMatches)) * 100.00f), 2).ToString() + "%";
                num_of_loses.Text = Math.Round(((Convert.ToDouble(Map.DefenderWin) / Convert.ToDouble(Map.TotalMatches)) * 100.00f), 2).ToString() + "%";
            }

            else
            {
                MessageBox.Show($"Invalid Map! Try Again!");
            }
        }

        private void AccentButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindMap("Accent");
        }

        private void BindButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindMap("Bind");
        }

        private void HavenButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindMap("Haven");
        }

        private void IceboxButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindMap("Icebox");
        }

        private void SplitButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindMap("Split");
        }
    }
}
