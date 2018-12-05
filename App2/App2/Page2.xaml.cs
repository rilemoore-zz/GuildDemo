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
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        void Handle_Clicked3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page12());
        }

        void Handle_Clicked4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page11());
        }

        void Handle_Clicked5(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page13());
        }
    }
}