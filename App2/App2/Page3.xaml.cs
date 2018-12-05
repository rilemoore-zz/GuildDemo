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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }

        void Handle_Clicked4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }

        void Handle_Clicked3(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}