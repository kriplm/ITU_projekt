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
using System.Windows.Input;
using Xamarin.Essentials;

namespace ITU_mb.Skripty
{
    class Model
    {

        public ICommand AddPlatba_comand => new Command(AddPlatba);

        /// <summary>
        /// Kolekce plateb
        /// </summary>
        /// 
        public ObservableCollection<Platba> Platby_Kontrola { get; set; }
        public ObservableCollection<Platba> Zjed_Platby { get; set; }
        public int Castka { get; set; }
        public string PredCisli { get; set; }
        public string CisloUctu { get; set; }
        public string KodBanky { get; set; }

        public ObservableCollection<Platba> Historie_Plateb { get; set; }
        public Skripty.Ucet TypUctu { get; set; }

        public List<radek> Listek { get; set; }
        public List<radek> Listek_filtr { get; set; }




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

        public Model()
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
                    HistoriePlateb = new ObservableCollection<Platba>(),
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
                    HistoriePlateb = new ObservableCollection<Platba>(),
                },
            };

            Platby_Kontrola = new ObservableCollection<Platba>();
            Zjed_Platby = new ObservableCollection<Platba>();
            Listek = new List<radek>();
            Listek_filtr = new List<radek>();

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

        public bool StahnoutAktualniKurz()
        {
            string url = "https://www.cnb.cz/cs/financni_trhy/devizovy_trh/kurzy_devizoveho_trhu/denni_kurz.xml";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();

                XmlSerializer serializer = new XmlSerializer(typeof(kurzy));
                kurzy Kurzy = (kurzy)serializer.Deserialize(responseStream);
                Listek = Kurzy.tabulka[0].radek;
                AktualizaceKurzListu();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void AktualizaceKurzListu()
        {
            for (int i = 0; i < Listek.Count; i++)
            {
                Listek[i].potvrzeno = Preferences.Get("Listek_potvrzeno" + Listek[i].kod, "False");
            }
            Listek_filtr.Clear();
            for (int i = 0; i < Listek.Count; i++)
            {
                if (Listek[i].potvrzeno == "True")
                {
                    Listek_filtr.Add(Listek[i]);
                }
            }
        }

        /// <summary>
        /// Funkce zobrazí/skryje dalsi nastaveni.
        /// Mění stav IsVisible = TRUE/FALSE
        /// </summary>
        internal void RozsirSkryjNastaveni(StackLayout layout)
        {
            layout.IsVisible = !layout.IsVisible;
        }

        public void AddPlatba()
        {
            if (Castka == 0 || CisloUctu == "")
            {
            }
            else
            {
                if (Preferences.Get("Mod", false))
                {
                    var pom = new Skripty.Platba
                    {
                        Castka = Castka,
                        CisloUctu = PredCisli + "-" + CisloUctu + "/" + KodBanky,
                        Potvrzeni = 0,
                        Barva = Color.Yellow,
                    };
                    Platby_Kontrola.Add(pom);
                    Zjed_Platby.Add(pom);
                }
                else
                {
                    TypUctu.HistoriePlateb.Add(new Skripty.Platba
                    {
                        Castka = Castka,
                        CisloUctu = PredCisli + "-" + CisloUctu + "/" + KodBanky,
                    });
                }
                SaveModel();
            }
        }

        public void SaveModel()
        {
            Preferences.Set("Listek_Count", Convert.ToString(Listek.Count));
            for (int i = 0; i < Listek.Count; i++)
            {
                Preferences.Set("Listek_Kod" + i, Convert.ToString(Listek[i].kod));
                Preferences.Set("Listek_potvrzeno" + Listek[i].kod, Convert.ToString(Listek[i].potvrzeno));
                Preferences.Set("Listek_potvrzeno" + i, Convert.ToString(Listek[i].potvrzeno));
                Preferences.Set("Listek_mena" + i, Convert.ToString(Listek[i].mena));
                Preferences.Set("Listek_zeme" + i, Convert.ToString(Listek[i].zeme));
                Preferences.Set("Listek_kurz" + i, Convert.ToString(Listek[i].kurz));
                Preferences.Set("Listek_mnozstvi" + i, Convert.ToString(Listek[i].mnozstvi));
            }

            Preferences.Set("Platby_kontrola_Count", Convert.ToString(Platby_Kontrola.Count));
            for (int i = 0; i < Platby_Kontrola.Count; i++)
            {
                Preferences.Set("Platby_kontrola_Castka" + i, Convert.ToString(Platby_Kontrola[i].Castka));
                Preferences.Set("Platby_kontrola_CisloUctu" + i, Convert.ToString(Platby_Kontrola[i].CisloUctu));
            }

            Preferences.Set("Zjed_Platby_Count", Convert.ToString(Zjed_Platby.Count));
            for (int i = 0; i < Zjed_Platby.Count; i++)
            {
                Preferences.Set("Zjed_Platby_Castka" + i, Convert.ToString(Zjed_Platby[i].Castka));
                Preferences.Set("Zjed_Platby_CisloUctu" + i, Convert.ToString(Zjed_Platby[i].CisloUctu));
                Preferences.Set("Zjed_Platby_Potvrzeni" + i, Convert.ToString(Zjed_Platby[i].Potvrzeni));
            }

            for (int j = 0; j < Ucty.Count; j++)
            {
                Preferences.Set(j + "HistoriePlateb_Count", Convert.ToString(Ucty[j].HistoriePlateb.Count));
                for (int i = 0; i < Ucty[j].HistoriePlateb.Count; i++)
                {
                    Preferences.Set(j + "HistoriePlateb_Castka" + i, Convert.ToString(Ucty[j].HistoriePlateb[i].Castka));
                    Preferences.Set(j + "HistoriePlateb_CisloUctu" + i, Convert.ToString(Ucty[j].HistoriePlateb[i].CisloUctu));
                }
            }
        }

        public void LoadModel()
        {
            Listek.Clear();
            for (int i = 0; i < Convert.ToInt32(Preferences.Get("Listek_Count", "0")); i++)
            {
                Listek.Add(new Skripty.radek 
                {
                    kod = Preferences.Get("Listek_Kod" + i, "x"),
                    potvrzeno = Preferences.Get("Listek_potvrzeno" + i, "False"),
                    mena = Preferences.Get("Listek_mena" + i, "x"),
                    zeme = Preferences.Get("Listek_zeme" + i, "x"),
                    kurz = Preferences.Get("Listek_kurz" + i, "0"),
                    mnozstvi = Preferences.Get("Listek_mnozstvi" + i, "0"),
                });
            }
            AktualizaceKurzListu();

            Platby_Kontrola.Clear();
            for (int i = 0; i < Convert.ToInt32(Preferences.Get("Platby_kontrola_Count", "0")); i++)
            {
                Platby_Kontrola.Add(new Skripty.Platba
                {
                    Castka = Convert.ToInt32(Preferences.Get("Platby_kontrola_Castka"+i, "0")),
                    CisloUctu = Preferences.Get("Platby_kontrola_CisloUctu" + i, "x"),
                });
            }

            Zjed_Platby.Clear();
            for (int i = 0; i < Convert.ToInt32(Preferences.Get("Zjed_Platby_Count", "0")); i++)
            {
                Zjed_Platby.Add(new Skripty.Platba
                {
                    Castka = Convert.ToInt32(Preferences.Get("Zjed_Platby_Castka" + i, "0")),
                    CisloUctu = Preferences.Get("Zjed_Platby_CisloUctu" + i, "x"),
                    Potvrzeni = Convert.ToInt32(Preferences.Get("Zjed_Platby_Potvrzeni" + i, "0")),
                });
                if (Zjed_Platby[i].Potvrzeni == 0)
                {
                    Zjed_Platby[i].Barva  = Color.Yellow;
                }
                else if (Zjed_Platby[i].Potvrzeni == 2)
                {
                    Zjed_Platby[i].Barva = Color.Red;
                }
                else
                {
                    Zjed_Platby[i].Barva = Color.Lime;
                }

            }

            for (int j = 0; j < Ucty.Count; j++)
            {
                Ucty[j].HistoriePlateb.Clear();
                for (int i = 0; i < Convert.ToInt32(Preferences.Get(j + "HistoriePlateb_Count", "0")); i++)
                {
                    Ucty[j].HistoriePlateb.Add(new Skripty.Platba
                    {
                        Castka = Convert.ToInt32(Preferences.Get(j + "HistoriePlateb_Castka" + i, "0")),
                        CisloUctu = Preferences.Get(j + "HistoriePlateb_CisloUctu" + i, "x"),
                    });
                }
            }
        }
    }
}
