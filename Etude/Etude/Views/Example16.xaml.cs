﻿using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Example16 : ContentPage
    {
        public Example16()
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