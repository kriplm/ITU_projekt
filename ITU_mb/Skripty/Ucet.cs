// Autor: xvadur04
using System;
using System.Collections.Generic;
using System.Text;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;
using System.Collections.ObjectModel;

namespace ITU_mb.Skripty
{
    class Ucet
    {
        public string NazevUctu { get; set; }
        public int Zustatek { get; set; }
        public int Blokace { get; set; }
        public bool IsVisible { get; set; }
        public Chart Graf { get; set; }
        public ObservableCollection<Platba> HistoriePlateb { get; set; }
    }
}
