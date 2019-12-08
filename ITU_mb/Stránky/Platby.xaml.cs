using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ITU_mb.Stránky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Platby : ContentPage
    {
        public Platby()
        {
            InitializeComponent();
            ComboBox.SelectedIndex = 0;
            InfoPicker.SelectedIndex = 0;
            MenaPicker.SelectedIndex = 0;
        }

        private void VyberUcet(object sender, EventArgs e)
        {
            var ucet = ComboBox.SelectedItem as Skripty.Ucet;
            ZustatekLabel.Text = "" + Convert.ToString(ucet.Zustatek) + " CZK";
            MenaPicker.SelectedIndex = 0;
        }

        private void ZmenaMeny(object sender, EventArgs e)
        {
            string pok = MenaPicker.SelectedItem.ToString();
            var ucet = ComboBox.SelectedItem as Skripty.Ucet;
            if (pok == "EUR")
            {

                double prepocet = ucet.Zustatek / 25.52;
                ZustatekLabel.Text = prepocet.ToString("0.##") + " EUR";
            }
            else
            {
                ZustatekLabel.Text = "" + Convert.ToString(ucet.Zustatek) + " CZK";
            }
        }

        private void RozsireneNastaveni_Pressed(object sender, EventArgs e)
        {
            RozsireneNastaveni.BackgroundColor = Color.Gray;
        }
        private void RozsireneNastaveni_Clicked(object sender, EventArgs e)
        {
            var vm = BindingContext as Skripty.ViewModel;
            vm.RozsirSkryjNastaveni(RozsireneNastaveni_Layout);
        }
        private void RozsireneNastaveni_Release(object sender, EventArgs e)
        {
            RozsireneNastaveni.BackgroundColor = Color.LightGray;
        }
    }
}