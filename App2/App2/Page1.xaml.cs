using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Title.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Chocolate;
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
        void Handle_Clicked3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page8());
        }
        void Handle_Clicked4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page9());
        }

    }
}