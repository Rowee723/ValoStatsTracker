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
    /// Interaction logic for PurchaseHistoryPage.xaml
    /// </summary>
    public partial class PurchaseHistoryPage : Page
    {
        public PurchaseHistoryPage()
        {
            InitializeComponent();
        }

        private void SubmitPurchaseHisotryButton_OnClick(object sender, RoutedEventArgs e)
        {
            string playerBattleTag = PlayerBattleTagText.Text;


            if (!string.IsNullOrEmpty(playerBattleTag))
            {
                int temp;
                if (int.TryParse(playerBattleTag, out temp))
                {
                    purchase_history PurchaseHistory = purchase_historyDA.GetPurchaseHistory(int.Parse(playerBattleTag));
                    if (PasswordText.Text == "admin")
                    {
                        if (PurchaseHistory != null)
                        {
                            puid.Text = "Battle Tag: ";
                            PlayerID.Text = PurchaseHistory.PlayerID.ToString();

                            purid.Text = "Purchase ID: ";
                            PurchaseID.Text = PurchaseHistory.PurchaseID.ToString();

                            pi.Text = "Purchased Item: ";
                            PurchasedItem.Text = PurchaseHistory.PurchasedItem.ToString();

                            cip.Text = "Total Cost: ";
                            CostInPHP.Text = PurchaseHistory.CostInPhp.ToString();

                            dp.Text = "Date Purchase: ";
                            DatePurchased.Text = PurchaseHistory.DatePurchased.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Invalid Battle Tag! Try Again!");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Password! Try Again!");
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid Battle Tag! Try Again!");
                }
            }
        }
    }
}
