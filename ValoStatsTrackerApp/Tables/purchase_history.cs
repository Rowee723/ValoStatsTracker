using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class purchase_history
    {
        private int Player_ID; //PK (not sure)
        private int Purchase_ID; //PK (not sure)
        private string Purchased_Item;
        private double Cost_In_Php;
        private double Paid_Amount_In_Php;
        private string Date_Purchased;

        public purchase_history(int playerId, int purchaseID, string purchasedItem, double costInPhp, double paidAmountInPhp, string datePurchased)
        {
            PlayerID = playerId;
            PurchaseID = purchaseID;
            PurchasedItem = purchasedItem;
            CostInPhp = costInPhp;
            PaidAmountInPhp = paidAmountInPhp;
            DatePurchased = datePurchased;
        }

        public int PlayerID
        {
            get { return Player_ID; }
            set { Player_ID = value; }
        }

        public int PurchaseID
        {
            get { return Purchase_ID; }
            set { Purchase_ID = value; }
        }

        public string PurchasedItem
        {
            get { return Purchased_Item; }
            set { Purchased_Item = value; }
        }

        public double CostInPhp
        {
            get { return Cost_In_Php; }
            set { Cost_In_Php = value; }
        }

        public double PaidAmountInPhp
        {
            get { return Paid_Amount_In_Php; }
            set { Paid_Amount_In_Php = value; }
        }

        public string DatePurchased
        {
            get { return Date_Purchased; }
            set { Date_Purchased = value; }
        }
    }
}
