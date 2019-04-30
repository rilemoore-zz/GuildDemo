using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Stuff;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FormsControls.Base;
using Newtonsoft.Json;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profile : ContentPage, IAnimationPage
    {
		public Profile ()
		{
			InitializeComponent ();
            Username.Text = "Username: " + Constants.CurrentUser.UserName;
            Name.Text = "Name: " + Constants.CurrentUser.FirstName + " " + Constants.CurrentUser.LastName;
            Email.Text = "Email: " + Constants.CurrentUser.Email;
            Bio.Text = "Player Bio: " + Constants.CurrentUser.Bio;
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



    }
}