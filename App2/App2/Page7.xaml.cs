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

        async void PostEvent()
        {
            GameEvent gameEvent = new GameEvent();
            gameEvent.EventTitle = EventTitle.Text;
            gameEvent.EndTime = int.Parse(EndTime.Text);
            gameEvent.StartTime = int.Parse(StartTime.Text);
            gameEvent.EventDate = Date.Text;
            gameEvent.UserId = int.Parse(UserID.Text);
            gameEvent.EventGame = Game.Text;
            gameEvent.Platform = Platform.Text;
            gameEvent.numberOfPlayers = int.Parse(NumPlayers.Text);

            string myPostedEvent = JsonConvert.SerializeObject(gameEvent);
            await App.RestService.PostResponse<string>(Constants.BaseUrl + "/events/new", myPostedEvent);
        }

        /* <DatePicker
     VerticalOptions = "Center"
     HorizontalOptions="Center"
     TextColor="#A00000"
     />*/
    }
}