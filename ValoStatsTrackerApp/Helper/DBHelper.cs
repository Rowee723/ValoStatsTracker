using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ValoStatsTrackerApp.Helper
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static void EstablishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "127.0.0.1";
                builder.UserID = "root";
                builder.Password = "admin";
                builder.Database = "valorantdata";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                MessageBox.Show("Database connection successful!", "Connection", MessageBoxButton.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection failed");
            }
        }

        public static MySqlCommand RunQuery(string query, string userID)
        {
            try
            {
                if(connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                connection.Close();
            }
            return cmd;
        }

        public static MySqlCommand GetPlayerQuery(string query, int battleTag)
        {
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@BattleTag", battleTag);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
            }
            return cmd;
        }

        public static MySqlCommand GetAgentQuery(string query, string agentName)
        {
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@AgentName", agentName);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
            }
            return cmd;
        }

        public static MySqlCommand GetMapQuery(string query, string mapName)
        {
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MapName", mapName);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
            }
            return cmd;
        }
    }
}
