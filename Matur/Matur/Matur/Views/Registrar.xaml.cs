﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matur.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void RegistrarNovo(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}