using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using App2.Stuff;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Java.Time.Format;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage, IAnimationPage
    {
		public RegisterPage ()
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

        async void HandleClicked(object sender, System.EventArgs e)
        {
            UserClass NewUser = new UserClass();
            NewUser.UserName = UserNameEntry.Text;
            NewUser.UserPassword = PasswordEntry.Text;
            NewUser.FirstName = FirstEntry.Text;
            NewUser.LastName = LastEntry.Text;
            NewUser.Email = EmailEntry.Text;
            NewUser.Age = int.Parse(AgeEntry.Text);
            NewUser.Bio = Bio.Text;
            string myNewUser = JsonConvert.SerializeObject(NewUser);
            await App.RestService.PostResponse<string>(Constants.CreateUserURL, myNewUser);
            await DisplayAlert("User Creation Successful", "", "Continue");

        }

    }
}