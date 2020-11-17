﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobEye.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OpenPortal(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.mymobeye.eu/"));
        }
        private async void RemoteControlPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoorPage());
        }

    }
}