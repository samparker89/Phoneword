using System;
using UIKit;
using Xamarin.Forms;

namespace Phoneword.iOS
{
    public partial class SamsCustomPage : ContentPage
    {
        public SamsCustomPage()
        {
            UIButton button = UIButton.FromType(UIButtonType.System);
            button.SetTitle("Hello from iOS", UIControlState.Normal);
        }
    }
}
