using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoStatsTrackerApp.Tables
{
    public class purchase_history
    {
        private string Player_ID; //PK (not sure)
        private string Purchase_ID; //PK (not sure)
        private string Purchased_Item;
        private string Cost_In_Php;
        private string Paid_Amount_In_Php;
        private string Date_Purchased;

        public purchase_history(string playerId, string purchaseID, string purchasedItem, string costInPhp, string paidAmountInPhp, string datePurchased)
        {
            PlayerID = playerId;
            PurchaseID = purchaseID;
            PurchasedItem = purchasedItem;
            CostInPhp = costInPhp;
            PaidAmountInPhp = paidAmountInPhp;
            DatePurchased = datePurchased;
        }

        public string PlayerID
        {
            get { return Player_ID; }
            set { Player_ID = value; }
        }

        public string PurchaseID
        {
            get { return Purchase_ID; }
            set { Purchase_ID = value; }
        }

        public string PurchasedItem
        {
            get { return Purchased_Item; }
            set { Purchased_Item = value; }
        }

        public string CostInPhp
        {
            get { return Cost_In_Php; }
            set { Cost_In_Php = value; }
        }

        public string PaidAmountInPhp
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
