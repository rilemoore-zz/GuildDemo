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
    public partial class Page11 : ContentPage, IAnimationPage
    {
        static RestService restService;
        public Page11()
        {
            InitializeComponent();
            GetEvents();
            this.BackgroundImage = "smallbackground.png";
        }

        public List<GameEvent> events = new List<GameEvent>();
        GameEvent xd = new GameEvent();
        async void GetEvents()
        {
            events = await App.RestService.GetResponse<List<GameEvent>>(Constants.LoginUrl);

            /*GameEvent GameEvent = new GameEvent();
            GameEvent.EndTime = "falsdkfjlkasd";
            string myPostedEvent = JsonConvert.SerializeObject(GameEvent);
            await App.RestService.PostResponse<string>(Constants.BaseUrl + "/events/new", myPostedEvent);*/
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            for (int z = 0; z < 2; z++)
            {
                FetchEvents();
            }



        }

        void FetchEvents()
        {
            int max = events.Count();
            int count = 0;
            if (count < max)
            {
                a.Text = events[0].EventTitle;
                count++;
            }
            if (count < max)
            {
                b.Text = events[1].EventTitle;
                count++;
            }
            if (count < max)
            {
                c.Text = events[2].EventTitle;
                count++;
            }
            if (count < max)
            {
                d.Text = events[3].EventTitle;
                count++;
            }
            if (count < max)
            {
                f.Text = events[4].EventTitle;
                count++;
            }
            if (count < max)
            {
                g.Text = events[5].EventTitle;
                count++;
            }
            if (count < max)
            {
                h.Text = events[6].EventTitle;
                count++;
            }
            if (count < max)
            {
                i.Text = events[7].EventTitle;
                count++;
            }
            if (count < max)
            {
                j.Text = events[8].EventTitle;
                count++;
            }
            if (count < max)
            {
                k.Text = events[9].EventTitle;
                count++;
            }
            if (count < max)
            {
                l.Text = events[10].EventTitle;
                count++;
            }

        }

        void Handle_ClickedA(object sender, System.EventArgs e)
        {
            if(events.Count>0)
            Navigation.PushAsync(new Page20());
        }

        void Handle_ClickedB(object sender, System.EventArgs e)
        {
            if (events.Count > 1)
                Navigation.PushAsync(new Page21());
        }

        void Handle_ClickedC(object sender, System.EventArgs e)
        {
            if (events.Count > 2)
                Navigation.PushAsync(new Page22());
        }

        void Handle_ClickedD(object sender, System.EventArgs e)
        {
            if (events.Count > 3)
                Navigation.PushAsync(new Page23());
        }

        void Handle_ClickedE(object sender, System.EventArgs e)
        {
            if (events.Count > 4)
                Navigation.PushAsync(new Page24());
        }

        void Handle_ClickedF(object sender, System.EventArgs e)
        {
            if (events.Count > 5)
                Navigation.PushAsync(new Page25());
        }

        void Handle_ClickedG(object sender, System.EventArgs e)
        {
            if (events.Count > 6)
                Navigation.PushAsync(new Page26());
        }

        void Handle_ClickedH(object sender, System.EventArgs e)
        {
            if (events.Count > 7)
                Navigation.PushAsync(new Page27());
        }

        void Handle_ClickedI(object sender, System.EventArgs e)
        {
            if (events.Count > 8)
                Navigation.PushAsync(new Page28());
        }

        void Handle_ClickedJ(object sender, System.EventArgs e)
        {
            if (events.Count > 9)
                Navigation.PushAsync(new Page29());
        }

        void Handle_ClickedK(object sender, System.EventArgs e)
        {
            if (events.Count > 10)
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