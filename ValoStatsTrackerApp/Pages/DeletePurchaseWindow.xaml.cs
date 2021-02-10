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
using System.Windows.Shapes;
using ValoStatsTrackerApp.DA_Layer;
using ValoStatsTrackerApp.Tables;

namespace ValoStatsTrackerApp.Pages
{
    /// <summary>
    /// Interaction logic for DeletePurchaseWindow.xaml
    /// </summary>
    public partial class DeletePurchaseWindow : Window
    {
        public DeletePurchaseWindow()
        {
            InitializeComponent();
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            string battleTag = BattleTag.Text;
            string purchaseID = PurchaseID.Text;

            if (!string.IsNullOrEmpty(battleTag))
            {
                int temp;
                if (int.TryParse(battleTag, out temp))
                {
                    purchase_history PurchaseHistory = purchase_historyDA.GetPurchase(int.Parse(battleTag));
                    if (PurchaseHistory != null)
                    {
                        if(PurchaseHistory.PurchaseID.ToString() == purchaseID)
                        {
                            purchase_historyDA.DeletePurchase(int.Parse(purchaseID));
                            Close();
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
    }
}
