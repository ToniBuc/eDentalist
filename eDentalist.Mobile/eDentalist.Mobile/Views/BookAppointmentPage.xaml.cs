﻿using eDentalist.Mobile.ViewModels;
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
    public partial class BookAppointmentPage : ContentPage
    {
        private BookAppointmentViewModel model = null;
        public BookAppointmentPage()
        {
            InitializeComponent();
            BindingContext = model = new BookAppointmentViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (model.SelectedProcedure != null)
            {
                timeTo.Time = timeFrom.Time + TimeSpan.Parse(model.SelectedProcedure.Duration);
            }
        }
        private async void UnfocusedPicker(object sender, EventArgs e)
        {
            if (model != null)
            {
                if (model.SelectedProcedure != null)
                {
                    timeTo.Time = timeFrom.Time + TimeSpan.Parse(model.SelectedProcedure.Duration);
                }
            }
        }
    }
}