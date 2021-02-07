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
    /// Interaction logic for WeaponsPage.xaml
    /// </summary>
    public partial class WeaponsPage : Page
    {
        public WeaponsPage()
        {
            InitializeComponent();
        }

        private void FindWeapon(string name)
        {
            weapons Weapon = weaponsDA.GetWeapons(name);

            if (Weapon != null)
            {
                weapon_name.Text = name;
                type.Text = Weapon.WeaponType;
                mag_size.Text = Weapon.MagazineSize.ToString();
                equip_time.Text = Weapon.EquipTime.ToString();
                reload_time.Text = Weapon.ReloadTime.ToString();
                cost.Text = Weapon.WeaponCost.ToString();
                head_dmg.Text = Weapon.HeadshotDamage.ToString();
                torso_dmg.Text = Weapon.TorsoDamage.ToString();
                leg_dmg.Text = Weapon.LegDamage.ToString();
            }
            else
            {
                MessageBox.Show($"Invalid Weapon! Try Again!");
            }
        }

        private void BulldogButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Bulldog");
        }

        private void ClassicButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Classic");
        }

        private void GhostButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Ghost");
        }

        private void GuardianButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Guardian");
        }

        private void JudgeButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Judge");
        }

        private void OdinButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Odin");
        }

        private void OperatorButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Operator");
        }

        private void SheriffButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Sheriff");
        }

        private void SpectreButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Spectre");
        }

        private void VandalButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeapon("Vandal");
        }
    }
}
