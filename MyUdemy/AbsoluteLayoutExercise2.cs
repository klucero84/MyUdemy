using System;

using Xamarin.Forms;

namespace MyUdemy
{
    public class AbsoluteLayoutExercise2 : ContentPage
    {
        public AbsoluteLayoutExercise2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

