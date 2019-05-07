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
	public partial class Page7 : ContentPage, IAnimationPage
    {
		public Page7 ()
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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //this.Title.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            PostEvent();
        }
        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            var date = Datepick.Date;
            var time = TimePick.Time;
            //Testbutton.Text = string.Format("{0}", date);

            //Testbutton.Text = ReturnTime(Testbutton.Text);
        }
        void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            //Platform.Text = e.NewDate.ToString();
        }

        string ReturnDate(string oldString)
        {
            string newstring = oldString.Substring(0, 10);
            return newstring;
        }

        string ReturnTime(string oldString)
        {
            string newstring = oldString.Substring(21, 26);


            return newstring;
        }

        async void PostEvent()
        {
            var date = Datepick.Date;
            var time = TimePick.Time;
            string datetime = string.Format("{0} \n {1}", date, time);
            string timestring = string.Format("{0}", time);

            GameEvent gameEvent = new GameEvent();
            gameEvent.EventTitle = EventTitle.Text;
            gameEvent.StartDate = ReturnDate(datetime);
            gameEvent.StartTime = timestring;
            gameEvent.UserId =  Constants.CurrentUser.ID;
            gameEvent.EventGame = Game.Text;
            gameEvent.Platform = Platform.Text;
            gameEvent.numberOfPlayers = int.Parse(NumPlayers.Text);
            gameEvent.Public = PublicPicker.SelectedIndex;
            gameEvent.Notes = "Note Test";
            string myPostedEvent = JsonConvert.SerializeObject(gameEvent);
            await App.RestService.PostResponse<string>(Constants.BaseUrl, myPostedEvent);
            await DisplayAlert("Event Creation Successful", "Your event is now published", "Continue");
        }

        /* <DatePicker
     VerticalOptions = "Center"
     HorizontalOptions="Center"
     TextColor="#A00000"
     />*/
    }
}