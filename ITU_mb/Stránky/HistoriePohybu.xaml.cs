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
        public HistoriePohybu(string nazevUctu)
        {
            InitializeComponent();
            var vm = BindingContext as Skripty.ViewModel;
            var ucet = vm.Ucty.Where(X => X.NazevUctu == nazevUctu).FirstOrDefault();
            ListPohybu.ItemsSource = ucet.HistoriePlateb;
        }
    }
}