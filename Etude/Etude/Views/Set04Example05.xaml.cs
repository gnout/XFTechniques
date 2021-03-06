﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set04Example05 : ContentPage
    {
        public uint AnimationSpeed = 250;
        public int DelaySpeed = 300;

        public Set04Example05()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.WhenAny(Label1.ScaleTo(1, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(Entry1.ScaleTo(1, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(Label2.ScaleTo(1, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(Entry2.ScaleTo(1, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(buttonSubmit.ScaleTo(1, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await buttonFacebook.ScaleTo(1, AnimationSpeed, Easing.SinIn);
        }

        private async void ButtonFacebook_Clicked(object sender, System.EventArgs e)
        {
            await Task.WhenAny(Label1.FadeTo(0, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(Entry1.FadeTo(0, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(Label2.FadeTo(0, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(Entry2.FadeTo(0, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await Task.WhenAny(buttonSubmit.FadeTo(0, AnimationSpeed, Easing.SinIn), Task.Delay(80));
            await buttonFacebook.FadeTo(0, AnimationSpeed, Easing.SinIn);
        }
    }
}