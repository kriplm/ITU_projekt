using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ITU_mb.Skripty
{
    class Platba
    {
        public int Castka { get; set; }
        public string CisloUctu { get; set; }
        public string Popis { get; set; }
        public int Potvrzeni { get; set; }
        public bool Visible { get; set; }

        public Color Barva { get; set; }
    }
}
