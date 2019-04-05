﻿using QuikRide.Interfaces;
using QuikRide.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuikRide.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeofencingPage : IContentPage
    {
        private bool shouldTimerRun;

        public GeofencingPage()
        {
            InitializeComponent();
        }

        public void PrepareForDispose()
        {
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext != null)
            {
                var vm = (GeofencingViewModel)BindingContext;

                shouldTimerRun = true;
                Device.StartTimer(TimeSpan.FromSeconds(5), () =>
                {
                    vm.CheckGeofenceStatus();
                    return shouldTimerRun; // True = Repeat again, False = Stop the timer
                });
            }
        }

        protected override void OnDisappearing()
        {
            shouldTimerRun = false;
            base.OnDisappearing();
        }
    }
}