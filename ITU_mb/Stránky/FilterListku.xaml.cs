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
    public partial class FilterListku : ContentPage
    {
        public FilterListku()
        {
            InitializeComponent();
            var bc = BindingContext as Skripty.Model;
            bc.LoadModel();
            for (int i = 0; i < bc.Listek.Count; i++)
            {
                if (bc.Listek[i].potvrzeno == "True")
                {
                    bc.Listek[i].check = true;
                }
                else
                {
                    bc.Listek[i].check = false;
                }
            }
            List.ItemsSource = bc.Listek;
        }

        private void Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var bc = BindingContext as Skripty.Model;
            var kod = (sender as CheckBox).BindingContext;
            Skripty.radek pom = (Skripty.radek) kod;
            bc.Listek.Where(X => X.kod == Convert.ToString(pom.kod)).FirstOrDefault().potvrzeno = Convert.ToString(pom.check);
            bc.SaveModel();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var bc = BindingContext as Skripty.Model;
            bc.AktualizaceKurzListu();
        }

    }
}