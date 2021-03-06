﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ITU_mb.Stránky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZjednodusPrehled : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var bc = BindingContext as Skripty.Model;
            bc.LoadModel();
            Listik.ItemsSource = null;
            Listik.ItemsSource = bc.Zjed_Platby;
        }
        public ZjednodusPrehled()
        {
            InitializeComponent();
            Ucet_ComboBox.SelectedIndex = 0;
        }

        private void Menu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu());
        }
        private void Grafy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Grafy());
        }
        private void Platba_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Platby());
        }
        private void VyberUcet(object sender, EventArgs e)
        {
            var ucet = Ucet_ComboBox.SelectedItem as Skripty.Ucet;
            Zustatek_label.Text = Convert.ToString(ucet.Zustatek) + " CZK";
            Blokace_label.Text = Convert.ToString(ucet.Blokace) + " CZK";
        }

        private void Platba_Press(object sender, EventArgs e)
        {
            Platba.BackgroundColor = Color.LightGray;
        }

        private void Platba_Release(object sender, EventArgs e)
        {
            Platba.BackgroundColor = Color.White;
        }

        private void Grafy_Press(object sender, EventArgs e)
        {
            Graf.BackgroundColor = Color.LightGray;
        }

        private void Grafy_Release(object sender, EventArgs e)
        {
            Graf.BackgroundColor = Color.White;
        }

        private void Menu_Press(object sender, EventArgs e)
        {
            Menu.BackgroundColor = Color.LightGray;
        }

        private void Menu_Release(object sender, EventArgs e)
        {
            Menu.BackgroundColor = Color.White;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var popis = (sender as ImageButton).CommandParameter;
            var bc = BindingContext as Skripty.Model;
            var kontrola = bc.Zjed_Platby.Where(x => x.CisloUctu == Convert.ToString(popis)).FirstOrDefault();
            if (kontrola.Potvrzeni != 0)
            {
                bc.Zjed_Platby.Remove(kontrola);
                bc.SaveModel();
            }
        }

    }
}