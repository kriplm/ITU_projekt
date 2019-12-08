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
        public Kontrola()
        {
            InitializeComponent();
            ComboBox.SelectedIndex = 0;
        }

        private void VyberUcet(object sender, EventArgs e)
        {
            var ucet = ComboBox.SelectedItem as Skripty.Ucet;
            Zustatek.Text = "" + Convert.ToString(ucet.Zustatek) + " CZK";
            Blokace.Text = "" + Convert.ToString(ucet.Blokace) + " CZK";
        }
    }
}