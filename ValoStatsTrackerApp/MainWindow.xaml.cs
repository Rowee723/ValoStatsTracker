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
            string userID = UsernameText.Text;

            Users aUser = UsersDA.RetriveUser(userID);
            MessageBox.Show($"Welcome {aUser.UserName}");
        }
    }
}
