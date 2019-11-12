﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zenith.View
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Sprite> sprites;

        public void AddSprite(Sprite sprite)
        {
            sprites.Add(sprite);
            //this.Children.Add(sprite.Image);
        }

        public MainPage()
        {
            InitializeComponent();
            sprites = new List<Sprite>();
        }
    }
}