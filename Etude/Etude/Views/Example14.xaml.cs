﻿using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Example14 : ContentPage
    {
        public Example14()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((BaseViewModel)BindingContext).LoadData = true;
        }
    }
}