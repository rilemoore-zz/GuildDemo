using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage, IAnimationPage
    {
		public Page3 ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
        }

        public IPageAnimation PageAnimation { get; } = new FadePageAnimation { Duration = AnimationDuration.Short, Subtype = AnimationSubtype.FromTop };

        public void OnAnimationStarted(bool isPopAnimation)
        {
            // Put your code here but leaving empty works just fine
        }

        public void OnAnimationFinished(bool isPopAnimation)
        {
            // Put your code here but leaving empty works just fine
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page15());
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