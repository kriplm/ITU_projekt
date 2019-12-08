//Autor: xprasi06, xvadur04
using System.Collections.ObjectModel;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ITU_mb.Skripty
{
    class ViewModel
    {

        /// <summary>
        /// Kolekce plateb
        /// </summary>
        public ObservableCollection<Platba> Platby { get; set; }

        /// <summary>
        /// Kolekce účtů
        /// </summary>
        public ObservableCollection<Ucet> Ucty { get; set; }

        /// <summary>
        /// Graf pro přijmy a výdaje -4 měsíc
        /// </summary>
        public Chart Graf1 { get; set; }

        /// <summary>
        /// Graf pro přijmy a výdaje -3 měsíc
        /// </summary>
        public Chart Graf2 { get; set; }

        /// <summary>
        /// Graf pro přijmy a výdaje -2 měsíc
        /// </summary>
        public Chart Graf3 { get; set; }

        /// <summary>
        /// Graf pro přijmy a výdaje -1 měsíc
        /// </summary>
        public Chart Graf4 { get; set; }

        /// <summary>
        /// Graf pro kategorie útrat
        /// </summary>
        public Chart Graf5 { get; set; }

        public ViewModel()
        {

            Ucty = new ObservableCollection<Ucet>
            {
                new Ucet
                {
                    NazevUctu = "Běžný účet",
                    Zustatek = 500,
                    Blokace = 100,
                    IsVisible = true,
                    Graf = new LineChart()
                    {
                        Entries = new[]
                        {
                            new Entry(1000)
                            {
                                Label = "1000",
                                ValueLabel = "+1000",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(1500)
                            {
                                Label = "1500",
                                ValueLabel = "+500",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(2000)
                            {
                                Label = "2000",
                                ValueLabel = "+500",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(600)
                            {
                                Label = "600",
                                ValueLabel = "-1400",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(500)
                            {
                                Label = "500",
                                ValueLabel = "-100",
                                Color = SKColors.RoyalBlue,
                            },
                        },
                        LineSize = 8,
                        LabelTextSize = 40,
                        PointSize = 40,
                        ValueLabelOrientation=Orientation.Horizontal,
                        LabelOrientation=Orientation.Horizontal,
                        LabelColor = SKColors.Black,
                    },
                    HistoriePlateb = new ObservableCollection<Platba>
                    {
                        new Platba
                        {
                            Castka = -100,
                            Popis = "Platba za XXXX",
                            Potvrzeni = 0,
                        },
                        new Platba
                        {
                            Castka = -1400,
                            Popis = "Paltba za XXXX",
                            Potvrzeni = 0,
                        },
                        new Platba
                        {
                            Castka = +500,
                            Popis = "Kapesné",
                            Potvrzeni = 0,
                        },
                    },
                },
                new Ucet
                {
                    NazevUctu = "Spořící účet",
                    Zustatek = 1000,
                    Blokace = 0,
                    IsVisible = false,
                    Graf = new LineChart()
                    {
                        Entries = new[]
                        {
                            new Entry(0)
                            {
                                Label = "200",
                                ValueLabel = "+200",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(400)
                            {
                                Label = "400",
                                ValueLabel = "+200",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(600)
                            {
                                Label = "600",
                                ValueLabel = "+200",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(800)
                            {
                                Label = "800",
                                ValueLabel = "+200",
                                Color = SKColors.RoyalBlue
                            },
                            new Entry(1000)
                            {
                                Label = "1000",
                                ValueLabel = "+200",
                                Color = SKColors.RoyalBlue
                            },
                        },
                        LineSize = 8,
                        LabelTextSize = 40,
                        PointSize = 40,
                        ValueLabelOrientation=Orientation.Horizontal,
                        LabelOrientation=Orientation.Horizontal,
                        LabelColor = SKColors.Black,
                    },
                    HistoriePlateb = new ObservableCollection<Platba>
                    {
                        new Platba
                        {
                            Castka = +200,
                            Popis = "Příjem",
                            Potvrzeni = 0,
                        },
                        new Platba
                        {
                            Castka = +200,
                            Popis = "Příjem",
                            Potvrzeni = 0,
                        },
                        new Platba
                        {
                            Castka = +200,
                            Popis = "Příjem",
                            Potvrzeni = 0,
                        },
                        new Platba
                        {
                            Castka = +200,
                            Popis = "Příjem",
                            Potvrzeni = 0,
                        },
                        new Platba
                        {
                            Castka = +200,
                            Popis = "Příjem",
                            Potvrzeni = 0,
                        },
                    },
                },
            };

            Platby = new ObservableCollection<Platba>
            {
                new Platba
                {
                    Castka = 1000,
                    Popis = "Testovaci položka 1",
                    Potvrzeni = 0,
                },
                new Platba
                {
                    Castka = 500,
                    Popis = "Testovaci položka 2",
                    Potvrzeni = 0,
                },
                new Platba
                {
                    Castka = 300,
                    Popis = "Testovaci položka 3",
                    Potvrzeni = 0,
                },
            };

            Graf1 = new BarChart()
            {
                Entries = new[]
                {
                    new Entry(500)
                    {
                        Label = "500",
                        ValueLabel = " ",
                        Color = SKColors.Red
                    },
                    new Entry(1000)
                    {
                        Label = "1000",
                        ValueLabel = " ",
                        Color = SKColors.Green
                    },
                },
                ValueLabelOrientation = Orientation.Horizontal,
                LabelOrientation = Orientation.Horizontal,
                LabelTextSize = 30,
                BarAreaAlpha = 0,
                LabelColor = SKColors.Black,
                BackgroundColor = SKColors.Transparent,
            };

            Graf2 = new BarChart()
            {
                Entries = new[]
                {
                    new Entry(500)
                    {
                        Label = "2000",
                        ValueLabel = " ",
                        Color = SKColors.Red
                    },
                    new Entry(1000)
                    {
                        Label = "1900",
                        ValueLabel = " ",
                        Color = SKColors.Green
                    },
                },
                ValueLabelOrientation = Orientation.Horizontal,
                LabelOrientation = Orientation.Horizontal,
                LabelTextSize = 30,
                BarAreaAlpha = 0,
                LabelColor = SKColors.Black,
                BackgroundColor = SKColors.Transparent,
            };

            Graf3 = new BarChart()
            {
                Entries = new[]
                {
                    new Entry(500)
                    {
                        Label = "1500",
                        ValueLabel = " ",
                        Color = SKColors.Red
                    },
                    new Entry(1000)
                    {
                        Label = "1600",
                        ValueLabel = " ",
                        Color = SKColors.Green
                    },

                },
                ValueLabelOrientation = Orientation.Horizontal,
                LabelOrientation = Orientation.Horizontal,
                LabelTextSize = 30,
                BarAreaAlpha = 0,
                LabelColor = SKColors.Black,
                BackgroundColor = SKColors.Transparent,
            };

            Graf4 = new BarChart()
            {
                Entries = new[]
                {
                    new Entry(500)
                    {
                        Label = "600",
                        ValueLabel = " ",
                        Color = SKColors.Red
                    },
                    new Entry(1000)
                    {
                        Label = "1500",
                        ValueLabel = " ",
                        Color = SKColors.Green
                    },

                },
                ValueLabelOrientation = Orientation.Horizontal,
                LabelOrientation = Orientation.Horizontal,
                LabelTextSize = 30,
                BarAreaAlpha = 0,
                LabelColor = SKColors.Black,
                BackgroundColor = SKColors.Transparent,
            };

            Graf5 = new DonutChart()
            {
                Entries = new[]
                {
                    new Entry(500)
                    {
                        Label = "Zábava",
                        ValueLabel = "500",
                        Color = SKColors.DodgerBlue
                    },
                    new Entry(400)
                    {
                        Label = "Jídlo",
                        ValueLabel = "400",
                        Color = SKColors.Orange
                    },
                    new Entry(800)
                    {
                        Label = "Účty",
                        ValueLabel = "800",
                        Color = SKColors.Red
                    },
                    new Entry(200)
                    {
                        Label = "Nákupy",
                        ValueLabel = "200",
                        Color = SKColors.DarkKhaki
                    },
                    new Entry(200)
                    {
                        Label = "Doprava",
                        ValueLabel = "200",
                        Color = SKColors.Brown
                    },
                    new Entry(200)
                    {
                        Label = "Ostatní",
                        ValueLabel = "200",

                        Color = SKColors.Green
                    },
                },
                LabelTextSize = 30,
                LabelColor = SKColors.White,
                BackgroundColor = SKColors.Transparent,
            };

        }

        /// <summary>
        /// Funkce zobrazí/skryje detail účtu.
        /// Mění stav IsVisible = TRUE/FALSE
        /// </summary>
        internal void RozsirSkryjUcet(Ucet ucet)
        {
            ucet.IsVisible = !ucet.IsVisible;
            UpdateUcty(ucet);
        }

        /// <summary>
        /// Funkce provede aktualizaci účtu
        /// </summary>
        private void UpdateUcty(Ucet ucet)
        {
            var index = Ucty.IndexOf(ucet);
            Ucty.Remove(ucet);
            Ucty.Insert(index, ucet);
        }

        /// <summary>
        /// Funkce zobrazí/skryje dalsi nastaveni.
        /// Mění stav IsVisible = TRUE/FALSE
        /// </summary>
        internal void RozsirSkryjNastaveni(StackLayout layout)
        {
            layout.IsVisible = !layout.IsVisible;
        }
    }
}
