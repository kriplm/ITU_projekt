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
    public partial class Hl_strana : ContentPage
    {
        public string Nazev;
        public Hl_strana()
        {
            InitializeComponent();

        }

        private void ListView_ZobrazUcet(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as Skripty.Model;
            var ucet = e.Item as Skripty.Ucet;
            vm.RozsirSkryjUcet(ucet);
            
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void HistoriePohybu_Clicked(object sender, EventArgs e)
        {
            var nazevUctu = (sender as Button).CommandParameter;
            Navigation.PushAsync(new HistoriePohybu(nazevUctu.ToString()));
        }
    }
}