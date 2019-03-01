using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Stuff;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FormsControls.Base;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page9 : ContentPage, IAnimationPage
    {
		public Page9 ()
		{
			InitializeComponent ();
            
            this.BackgroundImage = "smallbackground.png";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
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
            //if(!Entry_Username.Text.Equals("") && !Entry_Password.Text.Equals(""))
            
                User user = new User(Entry_Username.Text, Entry_Password.Text);
                if (user.CheckInfo())
                {
                    //DisplayAlert("Login", "Login Success", "Ok");
                    Navigation.PushAsync(new Page1());
                }
                else
                {
                    DisplayAlert("Login", "Login Not Correct", "Ok");
                }
            

        }


    }
}