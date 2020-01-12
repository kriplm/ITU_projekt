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
    public partial class Kontrola : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var bc = BindingContext as Skripty.Model;
            bc.LoadModel();
        }
        public Kontrola()
        {
            InitializeComponent();
            ComboBox.SelectedIndex = 0;
            var bc = BindingContext as Skripty.Model;
            bc.LoadModel();
        }

        private void VyberUcet(object sender, EventArgs e)
        {
            var ucet = ComboBox.SelectedItem as Skripty.Ucet;
            Zustatek.Text = "" + Convert.ToString(ucet.Zustatek) + " CZK";
            Blokace.Text = "" + Convert.ToString(ucet.Blokace) + " CZK";
        }

        private void yes_skryj_Clicked(object sender, EventArgs e)
        {
            var popis = (sender as ImageButton).CommandParameter;
            var bc = BindingContext as Skripty.Model;
            var kontrola = bc.Platby_Kontrola.Where(x => x.CisloUctu == Convert.ToString(popis)).FirstOrDefault();
            bc.Zjed_Platby.Where(x => x.CisloUctu == Convert.ToString(popis)).FirstOrDefault().Potvrzeni = 1;
            bc.Platby_Kontrola.Remove(kontrola);
            bc.SaveModel();
        }

        private void no_skryj_Clicked(object sender, EventArgs e)
        {
            var popis = (sender as ImageButton).CommandParameter;
            var bc = BindingContext as Skripty.Model;
            var kontrola = bc.Platby_Kontrola.Where(x => x.CisloUctu == Convert.ToString(popis)).FirstOrDefault();
            bc.Zjed_Platby.Where(x => x.CisloUctu == Convert.ToString(popis)).FirstOrDefault().Potvrzeni = 2;
            bc.Platby_Kontrola.Remove(kontrola);
            bc.SaveModel();
        }
    }
}