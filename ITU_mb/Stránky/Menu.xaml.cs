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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void Nastaveni_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nastaveni());
        }

        private void Nastaveni_Press(object sender, EventArgs e)
        {
            Nastaveni.BackgroundColor = Color.LightGray;
        }

        private void Nastaveni_Release(object sender, EventArgs e)
        {
            Nastaveni.BackgroundColor = Color.White;
        }

        private async void Tipy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tipy());
        }

        private void Tipy_Press(object sender, EventArgs e)
        {
            Tipy.BackgroundColor = Color.LightGray;
        }

        private void Tipy_Release(object sender, EventArgs e)
        {
            Tipy.BackgroundColor = Color.White;
        }

        private async void Kurz_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kurz());
        }

        private void Kurz_Press(object sender, EventArgs e)
        {
            Kurz.BackgroundColor = Color.LightGray;
        }

        private void Kurz_Release(object sender, EventArgs e)
        {
            Kurz.BackgroundColor = Color.White;
        }

        private async void Kontakt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kontakty());
        }

        private void Kontakt_Press(object sender, EventArgs e)
        {
            Kontakt.BackgroundColor = Color.LightGray;
        }

        private void Kontakt_Release(object sender, EventArgs e)
        {
            Kontakt.BackgroundColor = Color.White;
        }

        private void Out_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Prihlaseni();
        }

        private void Out_Press(object sender, EventArgs e)
        {
            Out.BackgroundColor = Color.LightGray;
        }

        private void Out_Release(object sender, EventArgs e)
        {
            Out.BackgroundColor = Color.White;
        }
    }
}