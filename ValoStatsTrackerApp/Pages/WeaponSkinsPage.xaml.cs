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
    /// Interaction logic for WeaponSkinsPage.xaml
    /// </summary>
    public partial class WeaponSkinsPage : Page
    {
        public WeaponSkinsPage()
        {
            InitializeComponent();
        }

        private void FindWeaponSkin(string name)
        {
            weapon_skins WeaponSkin = weapon_skinsDA.GetWeaponSkins(name);

            if (WeaponSkin != null)
            {
                avail.Text = "Available In Shop: ";
                price_w.Text = "Price: ";
                new_.Text = "Recent Release: ";
                cs.Text = "Collection Set: ";

                weapon_name.Text = name;
                if (WeaponSkin.IsWeaponNew) isNew.Text = "Yes"; else isNew.Text = "No";
                if(WeaponSkin.IsWeaponAvailable) available.Text = "Yes"; else available.Text = "No";
                price.Text = WeaponSkin.WeaponSkinPrice.ToString();
                collection.Text = WeaponSkin.WeaponSkinSet;
            }
            else
            {
                MessageBox.Show($"Invalid Weapon Skin! Try Again!");
            }
        }

        private void EgoStingerButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Ego Stinger");
        }

        private void ElderflameOperatorButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Elderflame Operator");
        }

        private void GlitchpopJudgeButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Glitchpop Judge");
        }

        private void NebulaGuardianButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Nebula Guardian");
        }

        private void OniKnifeButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Oni Knife");
        }

        private void PrimeVandalButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Prime Vandal");
        }

        private void SensationFrenzyButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Sensation Frenzy");
        }

        private void SingularityPhantomButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Singularity Phantom");
        }

        private void SmiteOdinButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("Smite Odin");
        }

        private void WinterWunderlandMarshalButton_OnClick(object sender, RoutedEventArgs e)
        {
            FindWeaponSkin("WinterWunderland Marshal");
        }
    }
}
