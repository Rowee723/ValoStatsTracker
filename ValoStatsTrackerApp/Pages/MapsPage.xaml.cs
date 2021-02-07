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

            }

            else
            {
                MessageBox.Show($"Invalid Map! Try Again!");
            }
        }
    }
}
