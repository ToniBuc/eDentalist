﻿using eDentalist.Mobile.ViewModels;
using eDentalist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eDentalist.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffWorkdaysPage : ContentPage
    {
        private StaffWorkdaysViewModel model = null;
        public StaffWorkdaysPage()
        {
            InitializeComponent();
            BindingContext = model = new StaffWorkdaysViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as UserWorkday;

            await Navigation.PushAsync(new StaffAppointmentsPage(item));
        }
    }
}