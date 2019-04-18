using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App2.Stuff;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BracketSetup : ContentPage, IAnimationPage
    {
		public BracketSetup ()
		{
            InitializeComponent();
            this.BackgroundImage = "smallbackground.png";
            BindingContext = this;

        }
        public int count = 0;
        //public static List<BracketNames> Entrants = new List<BracketNames>();


        public IPageAnimation PageAnimation { get; } = new FadePageAnimation { Duration = AnimationDuration.Short, Subtype = AnimationSubtype.FromTop };


        public void OnAnimationStarted(bool isPopAnimation)
        {
            // Put your code here but leaving empty works just fine
        }

        public void OnAnimationFinished(bool isPopAnimation)
        {
            // Put your code here but leaving empty works just fine
        }

        async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
           
            for (int i = 0; i < 4; i++)
            {
                Constants.Entrants.Add(new BracketNames());
            }
            var Entrant = new BracketNames
            {
                Name = "Riley",
                Seed = 1
            };

            Constants.Entrants[0].Name = Player0.Text;
            Constants.Entrants[0].Seed = 1;
            Constants.Entrants[0].Wins = 0;
            Constants.Entrants[0].Losses = 0;
            Constants.Entrants[1].Name = Player1.Text;
            Constants.Entrants[1].Seed = 2;
            Constants.Entrants[1].Wins = 0;
            Constants.Entrants[1].Losses = 0;
            Constants.Entrants[2].Name = Player2.Text;
            Constants.Entrants[2].Seed = 3;
            Constants.Entrants[2].Wins = 0;
            Constants.Entrants[2].Losses = 0;
            Constants.Entrants[3].Name = Player3.Text;
            Constants.Entrants[3].Seed = 4;
            Constants.Entrants[3].Wins = 0;
            Constants.Entrants[3].Losses = 0;
            //Constants.Entrants[4].Name = Player4.Text;
            //Constants.Entrants[4].Seed = 5;
            //Constants.Entrants[4].Wins = 0;
            //Constants.Entrants[4].Losses = 0;
            //Constants.Entrants[5].Name = Player5.Text;
            //Constants.Entrants[5].Seed = 6;
            //Constants.Entrants[5].Wins = 0;
            //Constants.Entrants[5].Losses = 0;
            //Constants.Entrants[6].Name = Player6.Text;
            //Constants.Entrants[6].Seed = 7;
            //Constants.Entrants[6].Wins = 0;
            //Constants.Entrants[6].Losses = 0;
            //Constants.Entrants[7].Name = Player7.Text;
            //Constants.Entrants[7].Seed = 8;
            //Constants.Entrants[7].Wins = 0;
            //Constants.Entrants[7].Losses = 0;
            var bracketPage = new DoubleElim
            {
                BindingContext = Entrant
            };
            if(Dropdown.SelectedIndex == 0)
            {
                await Navigation.PushAsync(new DoubleElim());
            }
            if(Dropdown.SelectedIndex == 2)
            {
                await Navigation.PushAsync(new RoundRobin());
            }

        }
    }
}