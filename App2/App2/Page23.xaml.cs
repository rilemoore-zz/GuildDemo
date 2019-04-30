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


namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page23 : ContentPage, IAnimationPage
    {
        public Page23()
        {
            InitializeComponent();
            this.BackgroundImage = "smallbackground.png";
            GetEvents();
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

        //public List<GameEvent> events = new List<GameEvent>();
        async void GetEvents()
        {
            //events = await App.RestService.GetResponse<List<GameEvent>>(Constants.LoginUrl);
            Title.Text = Constants.events[3].EventTitle;
            StartDate.Text = Constants.events[3].StartDate.ToString();
            StartTime.Text = Constants.events[3].StartTime.ToString();
            //UserId.Text = events[3].UserId.ToString();
            Game.Text = Constants.events[3].EventGame;
            Platform.Text = Constants.events[3].Platform.ToString();


            // NumPlayers.Text = events[3].numberOfPlayers.ToString();

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (Constants.RegisteredEvents.Contains(Constants.events[3]))
            {
                DisplayAlert("Error", "Event Already Registered", "Ok");
            }
            else
            {
                Constants.RegisteredEvents.Add(Constants.events[3]);
            }


        }

        async void Del(object sender, System.EventArgs e)
        {

            if (Constants.CurrentUser.ID == Constants.events[3].UserId)
            {
                string myPostedEvent = JsonConvert.SerializeObject(Constants.events[3]);
                await App.RestService.PostResponse<string>(Constants.ActualBaseUrl + "/delete/event", myPostedEvent);
                await DisplayAlert("Event deletion Successful", "Your event is now deleted", "Continue");
                Constants.events.Remove(Constants.events[3]);
            }

            else
            {
                await DisplayAlert("Permission Denied", "You do not own this event", "Ok");
            }
        }

        async void Inv(object sender, System.EventArgs e)
        {
            if (Constants.CurrentUser.ID == Constants.events[3].UserId)
            {
                AttendeeClass newattendee = new AttendeeClass();
                newattendee.EventID = Constants.events[3].eventId;
                string myAttendeeList = JsonConvert.SerializeObject(newattendee);
                await App.RestService.PostResponse<string>(Constants.ActualBaseUrl + "/create/attendeelist/" + InvitedUser.Text, myAttendeeList);
            }
            else
            {
                await DisplayAlert("Permission Denied", "You do not own this event", "Ok");
            }
        }

    }
}