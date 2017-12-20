using System;
using Xamarin.Forms;

namespace Phoneword
{
    public partial class SamsCustomPage : ContentPage
    {
        public SamsCustomPage()
        {
            Padding = new Thickness(10, 10, 10, 10);
            var red = new Label()
            {
                Text = "Stop",
                BackgroundColor = Color.Red,
                FontSize = 20
            };
            var yellow = new Label()
            {
                Text = "Slow down",
                BackgroundColor = Color.Yellow,
                FontSize = 20
            };
            var green = new Label()
            {
                Text = "Go",
                BackgroundColor = Color.Green,
                FontSize = 20
            };

            Content = new StackLayout()
            {
                Spacing = 10,
                Children = {red, yellow, green}
            };
        }
    }
}
