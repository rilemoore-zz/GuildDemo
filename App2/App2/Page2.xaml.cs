using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Stuff;
using App2.pages;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage, IAnimationPage
    {
		public Page2 ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
            this.Title.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
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
            Navigation.PushAsync(new MyEventsList());
        }


        void Handle_Clicked6(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EventSearch());
        }

        void Handle_Clicked7(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PendingEventInvites());
        }

    }
}