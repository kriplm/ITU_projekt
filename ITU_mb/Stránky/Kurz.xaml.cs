
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ITU_mb.Skripty;

namespace ITU_mb.Stránky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kurz : ContentPage
    {

        public Kurz()
        {
            InitializeComponent();
            var bc = BindingContext as Skripty.Model;
            bc.LoadModel();
            if (!bc.StahnoutAktualniKurz()) { }
            bc.AktualizaceKurzListu();
            List.ItemsSource = bc.Listek_filtr;
            bc.SaveModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var bc = BindingContext as Skripty.Model;
            bc.LoadModel();
            bc.AktualizaceKurzListu();
            List.ItemsSource = null;
            List.ItemsSource = bc.Listek_filtr;
        }

        private void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilterListku());
        }
    }
}