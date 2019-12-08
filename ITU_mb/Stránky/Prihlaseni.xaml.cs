using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITU_mb.Skripty;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Essentials;

namespace ITU_mb.Stránky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Prihlaseni : ContentPage
    {
        public Prihlaseni()
        {
            InitializeComponent();
        }

        void PrihlasitSe(object sender, EventArgs e)
        {
            Uzivatel uzivatel = new Uzivatel(Entry_Pin.Text);
            if (uzivatel.KontrolaPrihalseni())
            {
                //DisplayAlert("Přihlášení", "Příhlášení bylo úspěšné", "Ok");
                if (Preferences.Get("Mod", false))
                {
                    App.Current.MainPage = new NavigationPage(new Stránky.ZjednodusPrehled());
                }
                else
                {
                    App.Current.MainPage = new Hl_Navigace();
                }
            }
            else
            {
                DisplayAlert("Přihlášení", "Špatný PIN!", "Znovu");
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Entry_Pin.Focus();
        }

    }
}