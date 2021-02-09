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
using ValoStatsTrackerApp.Pages;
using ValoStatsTrackerApp.PD_Layer;
using ValoStatsTrackerApp.Tables;

namespace ValoStatsTrackerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool loggedIn = false;
        bool admin = false;

        public MainWindow()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();
        }

        private void GetUserButton_Click(object sender, RoutedEventArgs e)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            // User Message Box
            string userID = UsernameText.Text;

            Users aUser = UsersDA.RetriveUser(userID);
            if(aUser != null) {
                MessageBox.Show($"Welcome {aUser.UserName}");
            }
            else {
                MessageBox.Show($"Invalid Player ID! Try Again!");
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // outputs Player Stats table query
            string battleTag = UsernameText.Text;
            int iBattleTag = Int32.Parse(battleTag);

            player_stats aPlayer = player_statsDA.GetPlayerStats(iBattleTag);
            if(aPlayer != null ){
                MessageBox.Show($" Name: {aPlayer.Name} \n Rank Points: {aPlayer.RankPoints} \n Kill Count: {aPlayer.KillCount} \n Death Count: {aPlayer.DeathCount}");
            }

            else {
                MessageBox.Show($"Invalid Player ID! Try Again!");
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* 
            // outputs agents table query
            string agentName = UsernameText.Text;
            agents aAgent = agentsDA.GetAgents(agentName);
            if (aAgent != null) {
                MessageBox.Show($" Agent Name: {aAgent.AgentName} \n Agent Type: {aAgent.AgentType} \n First Ability: {aAgent.FirstAbility} \n Second Ability: {aAgent.SecondAbility} \n " +
                            $"Second Ability: {aAgent.ThirdAbility} \n Ultimate Ability: {aAgent.UltimateAbility} \n First Ability Cost: {aAgent.FirstAbility_Cost} " +
                            $"\n Second Ability Cost: {aAgent.SecondAbilityCost} \n Third Ability Recharge Method: {aAgent.ThirdAbilityCharge_Method} \n Ultimate Ability Points: {aAgent.UltimateAbilityPoints}");
            }

            else {
                MessageBox.Show($"Invalid Agent Name! Try Again!");
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // outputs map table query
            string mapName = UsernameText.Text;
            maps aMap = mapsDA.GetMaps(mapName);
            if (aMap != null) {
                MessageBox.Show($" Map Name: {aMap.MapName} \n Total Matches: {aMap.TotalMatches} \n Attackers Win: {aMap.AttackerWin} \n Defenders Win: {aMap.DefenderWin}");
            }

            else {
                MessageBox.Show($"Invalid Map Name! Try Again!");
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // outputs weapon table query
            string weaponName = UsernameText.Text;
            weapons aWeapon = weaponsDA.GetWeapons(weaponName);
            if (aWeapon != null)
            {
                MessageBox.Show($" Weapon Name: {aWeapon.WeaponName} \n Weapon Type: {aWeapon.WeaponType} \n Mag Size: {aWeapon.MagazineSize} \n Equip Time: {aWeapon.EquipTime} " +
                    $"\n Reload Time: {aWeapon.ReloadTime} \n Cost:{aWeapon.WeaponCost} \n Headshot Damage: {aWeapon.HeadshotDamage} \n Torse Damage: {aWeapon.TorsoDamage} \n Leg Damage: {aWeapon.LegDamage}");
            }

            else
            {
                MessageBox.Show($"Invalid Weapon Name! Try Again!");
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // outputs weapon table query
            /*
            string weaponSkinName = UsernameText.Text;
            weapon_skins aWeaponSkin = weapon_skinsDA.GetWeaponSkins(weaponSkinName);
            if (aWeaponSkin != null)
            {
                MessageBox.Show($" Weapon Name: {aWeaponSkin.WeaponSkinName} \n Recently Released: {aWeaponSkin.IsWeaponNew} \n Available in Shop: {aWeaponSkin.IsWeaponAvailable}" +
                                $" \n Price (VP): {aWeaponSkin.WeaponSkinPrice} \n Collection Set: {aWeaponSkin.WeaponSkinSet}");
            }

            else
            {
                MessageBox.Show($"Invalid Weapon Skin Name! Try Again!");
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // outputs purchase history table query
            string uPurchaseHistoryID = UsernameText.Text;
            int iPurchaseHistoryID = Int32.Parse(uPurchaseHistoryID);

            purchase_history aPurchaseHistory = purchase_historyDA.GetPurchaseHistory(iPurchaseHistoryID);
            if (aPurchaseHistory != null)
            {
                MessageBox.Show($" Player ID: {aPurchaseHistory.PlayerID} \n Purchase ID: {aPurchaseHistory.PurchaseID} \n Purchased Item: {aPurchaseHistory.PurchasedItem}" +
                                $" \n Cost In PHP: {aPurchaseHistory.CostInPhp} \n Paid Amount in PHP: {aPurchaseHistory.PaidAmountInPhp} \n Date Purchased: {aPurchaseHistory.DatePurchased}");
            }

            else
            {
                MessageBox.Show($"Invalid Purchase ID! Try Again!");
            }
            */
        }

        private void PlayertStatsButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (loggedIn)
            {
                Main.Content = new PlayerStatsPage();
            }
            else
            {
                MessageBox.Show("Login required", "Warning", MessageBoxButton.OK);
            }
        }

        private void AgentsButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (loggedIn)
            {
                Main.Content = new AgentsPage();

            }
            else
            {
                MessageBox.Show("Login required", "Warning", MessageBoxButton.OK);
            }
        }

        private void WeaponsButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (loggedIn) 
            { 
                Main.Content = new WeaponsPage();
            }
            else
            {
                MessageBox.Show("Login required", "Warning", MessageBoxButton.OK);
            }
        }

        private void MapsButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (loggedIn) 
            { 
                Main.Content = new MapsPage();
            }
            else
            {
                MessageBox.Show("Login required", "Warning", MessageBoxButton.OK);
            }
        }

        private void WeaponSkinsButton_OnClick(object sender, RoutedEventArgs e)
        {
            if(loggedIn)
            { 
                Main.Content = new WeaponSkinsPage();
            }
            else
            {
                MessageBox.Show("Login required", "Warning", MessageBoxButton.OK);
            }
        }

        private void PurchaseHistoryButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (loggedIn) 
            { 
                Main.Content = new PurchaseHistoryPage();
            }
            else
            {
                MessageBox.Show("Login required", "Warning", MessageBoxButton.OK);
            }
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            player_stats Player = player_statsDA.GetPlayerStats(int.Parse(battleID.Text));
            if (username.Text == "Admin" && battleID.Text == "12345")
            {
                loggedIn = true;
                admin = true;
                MessageBox.Show("Successfully logged in as Admin!", "Login success", MessageBoxButton.OK);
            }
            else if (Player != null)
            {
                if (username.Text == Player.Name)
                {
                    loggedIn = true;
                    MessageBox.Show("Successfully logged in as " + username.Text + "!", "Login success", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("Invalid username", "Login error", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or battle ID!", "Login error", MessageBoxButton.OK);
            }
        }

        private void AdminButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (loggedIn)
            {
                if (admin)
                {
                    Main.Content = new AdminPage();
                }
                else
                {
                    MessageBox.Show("Access restricted!", "Login error", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or battle ID!", "Login error", MessageBoxButton.OK);
            }
        }
    }
}
