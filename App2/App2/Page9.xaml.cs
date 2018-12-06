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
	public partial class Page9 : ContentPage
	{
		public Page9 ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}