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

namespace ValoStatsTrackerApp.Pages
{
    /// <summary>
    /// Interaction logic for InsertPurchaseWindow.xaml
    /// </summary>
    public partial class InsertPurchaseWindow : Window
    {
        public InsertPurchaseWindow()
        {
            InitializeComponent();
        }

        private void InsertButton_OnClick(object sender, RoutedEventArgs e)
        {
            string player_id = playerID.Text;
            string purchase_id = purchaseID.Text;
            string purchase_item = purchaseItem.Text;
            string purchase_cost = purchaseCost.Text;
            string paid_amout = paidAmount.Text;
            string purchase_date = purchaseDate.Text;

            purchase_historyDA.InsertPurchase(int.Parse(player_id), int.Parse(purchase_id), purchase_item, int.Parse(purchase_cost), int.Parse(paid_amout), purchase_date);

            Close();
        }
    }
}
