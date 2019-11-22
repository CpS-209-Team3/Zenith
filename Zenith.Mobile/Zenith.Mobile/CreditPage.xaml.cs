﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zenith.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditPage : ContentPage
    {
        public CreditPage()
        {
            InitializeComponent();
        }

        private void btn_Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}