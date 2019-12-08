using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace ITU_mb.Stránky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nastaveni : ContentPage
    {
        public Nastaveni()
        {
            InitializeComponent();
            ZjedMod.IsToggled = Preferences.Get("Mod", false);
        }

        private void Mod_Toggled(object sender, ToggledEventArgs e)
        {
            Preferences.Set("Mod", e.Value);
        }

        protected override void OnDisappearing()
        {
            if (ZjedMod.IsToggled)
            {

                App.Current.MainPage = new NavigationPage(new Stránky.ZjednodusPrehled());
            }
            else
            {
                App.Current.MainPage = new Hl_Navigace();
            }
        }
    }
}