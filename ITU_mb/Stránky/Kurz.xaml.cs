
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
            StahnoutAktualniKurz();
        }

        private void StahnoutAktualniKurz()
        {
            string url = "https://www.cnb.cz/cs/financni_trhy/devizovy_trh/kurzy_devizoveho_trhu/denni_kurz.xml";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            XmlSerializer serializer = new XmlSerializer(typeof(kurzy));
            kurzy listKurzu = (kurzy)serializer.Deserialize(responseStream);
            List.ItemsSource = listKurzu.tabulka[0].radek;
        }
    }
}