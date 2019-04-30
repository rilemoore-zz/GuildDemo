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

namespace App2.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PendingEventInvites : ContentPage, IAnimationPage
    {
		public PendingEventInvites ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
        }

        static RestService restService;


        // public List<GameEvent> events = new List<GameEvent>();
        async void GetEvents()
        {
            Constants.InviteEvents = await App.RestService.GetResponse<List<GameEvent>>(Constants.ActualBaseUrl + "/attendee/events/" + Constants.CurrentUser.ID);
            Constants.events = Constants.InviteEvents;

            /*GameEvent GameEvent = new GameEvent();
            GameEvent.EndTime = "falsdkfjlkasd";
            string myPostedEvent = JsonConvert.SerializeObject(GameEvent);
            await App.RestService.PostResponse<string>(Constants.BaseUrl + "/events/new", myPostedEvent);*/
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            GetEvents();
            for (int z = 0; z < 2; z++)
            {
                FetchEvents();
            }



        }

        void FetchEvents()
        {
            int max = Constants.events.Count();
            int count = 0;
            if (count < max)
            {
                a.Text = Constants.events[0].EventTitle;
                count++;
            }
            if (count < max)
            {
                b.Text = Constants.events[1].EventTitle;
                count++;
            }
            if (count < max)
            {
                c.Text = Constants.events[2].EventTitle;
                count++;
            }
            if (count < max)
            {
                d.Text = Constants.events[3].EventTitle;
                count++;
            }
            if (count < max)
            {
                f.Text = Constants.events[4].EventTitle;
                count++;
            }
            if (count < max)
            {
                g.Text = Constants.events[5].EventTitle;
                count++;
            }
            if (count < max)
            {
                h.Text = Constants.events[6].EventTitle;
                count++;
            }
            if (count < max)
            {
                i.Text = Constants.events[7].EventTitle;
                count++;
            }
            if (count < max)
            {
                j.Text = Constants.events[8].EventTitle;
                count++;
            }
            if (count < max)
            {
                k.Text = Constants.events[9].EventTitle;
                count++;
            }
            if (count < max)
            {
                l.Text = Constants.events[10].EventTitle;
                count++;
            }

        }

        void Handle_ClickedA(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 0)
                Navigation.PushAsync(new Page20());
        }

        void Handle_ClickedB(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 1)
                Navigation.PushAsync(new Page21());
        }

        void Handle_ClickedC(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 2)
                Navigation.PushAsync(new Page22());
        }

        void Handle_ClickedD(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 3)
                Navigation.PushAsync(new Page23());
        }

        void Handle_ClickedE(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 4)
                Navigation.PushAsync(new Page24());
        }

        void Handle_ClickedF(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 5)
                Navigation.PushAsync(new Page25());
        }

        void Handle_ClickedG(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 6)
                Navigation.PushAsync(new Page26());
        }

        void Handle_ClickedH(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 7)
                Navigation.PushAsync(new Page27());
        }

        void Handle_ClickedI(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 8)
                Navigation.PushAsync(new Page28());
        }

        void Handle_ClickedJ(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 9)
                Navigation.PushAsync(new Page29());
        }

        void Handle_ClickedK(object sender, System.EventArgs e)
        {
            if (Constants.events.Count > 10)
                Navigation.PushAsync(new Page30());
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