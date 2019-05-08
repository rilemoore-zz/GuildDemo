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

        public List<UserClass> UserList = new List<UserClass>();

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

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //if(!Entry_Username.Text.Equals("") && !Entry_Password.Text.Equals(""))
            if(Entry_Username.Text == "" || Entry_Password.Text == "")
            {
                await DisplayAlert("Login", "Login Not Correct", "Ok");
                return;
            }
            UserClass NewUser = new UserClass();

            NewUser.UserName = Entry_Username.Text;
            NewUser.UserPassword = Entry_Password.Text;
           // bool LogInSuccess = false;
           // int truefalse;
            UserList = await App.RestService.GetResponse<List<UserClass>>(Constants.CheckLoginURL + "/" + NewUser.UserName +"/" + NewUser.UserPassword);
            if (UserList[0].UserName == "ERROR" || UserList[0].UserPassword == "ERROR")
            {
                await DisplayAlert("Login", "Login Not Correct", "Ok");
                return;
            }
            Constants.CurrentUser = UserList[0];

            if (UserList[0].UserName == Entry_Username.Text && UserList[0].UserPassword == Entry_Password.Text)
            {
                await Navigation.PushAsync(new Page1());
            }
            else
            {
                await DisplayAlert("Login", "Login Not Correct", "Ok");
            }
            //User user = new User(Entry_Username.Text, Entry_Password.Text);
            //if (user.CheckInfo())
            //{
            //await Navigation.PushAsync(new Page1());
            //}
            //else
            //{
            //await DisplayAlert("Login", "Login Not Correct", "Ok");
            //}


        }

        async void Handle_Clicked2(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }


    }
}