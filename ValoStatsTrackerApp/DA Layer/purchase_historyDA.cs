using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValoStatsTrackerApp.Helper;
using ValoStatsTrackerApp.Tables;

namespace ValoStatsTrackerApp.DA_Layer
{
    public static class purchase_historyDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static List<purchase_history> GetPurchaseHistory(int purchaseHistoryID)
        {
            string query = "SELECT * FROM valorantdata.purchase_history WHERE player_id = (@PurchaseHistoryID)";
            cmd = DBHelper.GetPurchaseHistoryQuery(query, purchaseHistoryID);

            List<purchase_history> list = new List<purchase_history>();
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string uPlayerID = dr["player_id"].ToString();

                    string uPurchaseID = dr["purchased_id"].ToString();

                    string uPurchasedItem = dr["purchased_item"].ToString();

                    string uCostInPhp = dr["cost_in_php"].ToString();

                    string uPaidAmountInPhp = dr["paid_amount_in_php"].ToString();

                    string uDatePurchased = dr["date_purchased"].ToString();

                    purchase_history aUser = new purchase_history(uPlayerID, uPurchaseID, uPurchasedItem, uCostInPhp, uPaidAmountInPhp, uDatePurchased);
                    list.Add(aUser);
                }
            }

            return list;
        }

        public static purchase_history GetPurchase(int purchaseHistoryID)
        {
            string query = "SELECT * FROM purchase_history WHERE player_id = (@PurchaseHistoryID) limit 1";
            cmd = DBHelper.GetPurchaseHistoryQuery(query, purchaseHistoryID);

            purchase_history aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string uPlayerID = dr["player_id"].ToString();

                    string uPurchaseID = dr["purchased_id"].ToString();

                    string uPurchasedItem = dr["purchased_item"].ToString();

                    string uCostInPhp = dr["cost_in_php"].ToString();

                    string uPaidAmountInPhp = dr["paid_amount_in_php"].ToString();

                    string uDatePurchased = dr["date_purchased"].ToString();

                    aUser = new purchase_history(uPlayerID, uPurchaseID, uPurchasedItem, uCostInPhp, uPaidAmountInPhp, uDatePurchased);
              
                }
            }
            return aUser;
        }

        public static void InsertPurchase(int playerID, int purchaseID, string purchaseItem, int purchaseCost, int purchaseAmountPaid, string PurchaseDate)
        {
            string query = "BEGIN; INSERT INTO purchase_history VALUES ((@PlayerID), (@PurchaseID), (@PurchaseItem), (@PurchaseCost), (@PurchaseAmountPaid), DATE (@PurchaseDate)); COMMIT;";
            cmd = DBHelper.InsertPurchaseHistory(query, playerID, purchaseID, purchaseItem, purchaseCost, purchaseAmountPaid, PurchaseDate);
        }

        public static void DeletePurchase(int purchaseID)
        {
            string query = "BEGIN; DELETE FROM purchase_history WHERE purchased_id = (@PurchaseID); COMMIT;";
            cmd = DBHelper.DeletePurchaseHistory(query, purchaseID);
        }
    }
}
