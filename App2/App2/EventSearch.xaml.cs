using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FormsControls.Base;
using App2.Stuff;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventSearch : ContentPage, IAnimationPage
    {
		public EventSearch()
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

        public List<GameEvent> events = new List<GameEvent>();
        GameEvent xd = new GameEvent();

        async void SearchByPlatform(object sender, System.EventArgs e)
        {
            Constants.SearchedEvents = await App.RestService.GetResponse<List<GameEvent>>(Constants.SearchUrl +"/platform/" + Platform.Text);
            for (int i = 0; i < Constants.SearchedEvents.Count; i++)
            {
                if (Constants.SearchedEvents[i].Public == 0)
                {
                    Constants.SearchedEvents.Remove(Constants.SearchedEvents[i]);
                }
            }
            await Navigation.PushAsync(new SearchedEvents());
        }

        async void SearchByGameName(object sender, System.EventArgs e)
        {
            Constants.SearchedEvents = await App.RestService.GetResponse<List<GameEvent>>(Constants.SearchUrl + "/game/" + GameName.Text);
            for (int i = 0; i < Constants.SearchedEvents.Count; i++)
            {
                if (Constants.SearchedEvents[i].Public == 0)
                {
                    Constants.SearchedEvents.Remove(Constants.SearchedEvents[i]);
                }
            }
            await Navigation.PushAsync(new SearchedEvents());
        }

        async void SearchByEventName(object sender, System.EventArgs e)
        {
            Constants.SearchedEvents = await App.RestService.GetResponse<List<GameEvent>>(Constants.SearchUrl + "/title/" + EventName.Text);
            for (int i = 0; i < Constants.SearchedEvents.Count; i++)
            {
                if (Constants.SearchedEvents[i].Public == 0)
                {
                    Constants.SearchedEvents.Remove(Constants.SearchedEvents[i]);
                }
            }
            await Navigation.PushAsync(new SearchedEvents());
        }

        async void SearchAll(object sender, System.EventArgs e)
        {
            Constants.SearchedEvents = await App.RestService.GetResponse<List<GameEvent>>(Constants.LoginUrl + "/public");

            await Navigation.PushAsync(new SearchedEvents());
        }

    }
}