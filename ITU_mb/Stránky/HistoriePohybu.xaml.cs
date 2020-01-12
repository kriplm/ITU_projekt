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
    public partial class HistoriePohybu : ContentPage
    {
        public string nazev;
        public HistoriePohybu(string nazevUctu)
        {
            InitializeComponent();
            var vm = BindingContext as Skripty.Model;
            vm.LoadModel();
            var ucet = vm.Ucty.Where(X => X.NazevUctu == nazevUctu).FirstOrDefault();
            nazev = nazevUctu;
            ListPohybu.ItemsSource = ucet.HistoriePlateb;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var popis = (sender as ImageButton).CommandParameter;
            var bc = BindingContext as Skripty.Model;
            var ucet = bc.Ucty.Where(X => X.NazevUctu == nazev).FirstOrDefault();
            var kontrola = ucet.HistoriePlateb.Where(x => x.CisloUctu == Convert.ToString(popis)).FirstOrDefault();
            ucet.HistoriePlateb.Remove(kontrola);
            bc.SaveModel();
        }
    }
}