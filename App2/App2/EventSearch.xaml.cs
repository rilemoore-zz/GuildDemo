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
	public partial class Page13 : ContentPage, IAnimationPage
    {
		public Page13 ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Title.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
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
            
        }

        

    }
}