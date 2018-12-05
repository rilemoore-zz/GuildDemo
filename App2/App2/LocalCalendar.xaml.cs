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
	public partial class LocalCalendar : ContentPage
	{
		public LocalCalendar ()
		{
			InitializeComponent ();
            myLocalImage.Source = ImageSource.FromFile("hat.PNG");
		}
	}
}