using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyUdemy
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //embedding image for app
            image.Source = ImageSource.FromResource("MyUdemy.Images.background.jpg");
        }
    }
}
