using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Stuff;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RoundRobin : ContentPage
	{
		public RoundRobin ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
            
            Wins0.Text = Constants.Entrants[0].Wins.ToString();
            Losses0.Text = Constants.Entrants[0].Losses.ToString();
            Wins1.Text = Constants.Entrants[1].Wins.ToString();
            Losses1.Text = Constants.Entrants[1].Losses.ToString();
            Wins2.Text = Constants.Entrants[2].Wins.ToString();
            Losses2.Text = Constants.Entrants[2].Losses.ToString();
            Wins3.Text = Constants.Entrants[3].Wins.ToString();
            Losses3.Text = Constants.Entrants[3].Losses.ToString();
            Match0A.Text = Constants.Entrants[0].Name;
            Match0B.Text = Constants.Entrants[3].Name;
            Match1A.Text = Constants.Entrants[1].Name;
            Match1B.Text = Constants.Entrants[2].Name;
            Match2A.Text = Constants.Entrants[0].Name;
            Match2B.Text = Constants.Entrants[2].Name;
            Match3A.Text = Constants.Entrants[1].Name;
            Match3B.Text = Constants.Entrants[3].Name;
            Match4A.Text = Constants.Entrants[2].Name;
            Match4B.Text = Constants.Entrants[3].Name;
            Match5A.Text = Constants.Entrants[0].Name;
            Match5B.Text = Constants.Entrants[1].Name;
            PlayerA.Text = Constants.Entrants[0].Name;
            PlayerB.Text = Constants.Entrants[1].Name;
            PlayerC.Text = Constants.Entrants[2].Name;
            PlayerD.Text = Constants.Entrants[3].Name;
        }
        void Update()
        {
            if(Match0A.IsEnabled == false && Match1A.IsEnabled == false && Match2A.IsEnabled == false && Match3A.IsEnabled == false && Match4A.IsEnabled == false && Match5A.IsEnabled == false)
            {
                bool tie = false;
                int WinnerScore = 0;
                string tiedplayer = "";
                    string Winner = "";
                for(int i = 0; i < 4; i++)
                {
                    if (Constants.Entrants[i].Wins > WinnerScore)
                    {
                        WinnerScore = Constants.Entrants[i].Wins;
                        Winner = Constants.Entrants[i].Name;
                        tie = false;
                    }
                    else if(Constants.Entrants[i].Wins == WinnerScore)
                    {
                        tie = true;
                        tiedplayer = Constants.Entrants[i].Name;
                    }
                }
                if (tie == false)
                {
                    DisplayAlert(Winner + " Wins!", "", "Continue");
                }
                else if(tie == true)
                {
                    DisplayAlert(Winner + " and " + tiedplayer + " Tied!","", "Continue");
                }
            }
        }
        void Match0a(object sender, System.EventArgs e)
        {
           
            Match0A.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[0].Wins++;
            Constants.Entrants[3].Losses++;
            Wins0.Text = Constants.Entrants[0].Wins.ToString();
            Losses3.Text = Constants.Entrants[3].Losses.ToString();
            Match0A.IsEnabled = false;
            Match0B.IsEnabled = false;
            Update();
        }

        void Match0b(object sender, System.EventArgs e)
        {
            Match0B.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[3].Wins++;
            Constants.Entrants[0].Losses++;
            Wins3.Text = Constants.Entrants[3].Wins.ToString();
            Losses0.Text = Constants.Entrants[0].Losses.ToString();
            Match0A.IsEnabled = false;
            Match0B.IsEnabled = false;
            Update();
        }

        void Match1a(object sender, System.EventArgs e)
        {

            Match1A.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[1].Wins++;
            Constants.Entrants[2].Losses++;
            Wins1.Text = Constants.Entrants[1].Wins.ToString();
            Losses2.Text = Constants.Entrants[2].Losses.ToString();
            Match1A.IsEnabled = false;
            Match1B.IsEnabled = false;
            Update();
        }

        void Match1b(object sender, System.EventArgs e)
        {
            Match1B.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[2].Wins++;
            Constants.Entrants[1].Losses++;
            Wins2.Text = Constants.Entrants[2].Wins.ToString();
            Losses1.Text = Constants.Entrants[1].Losses.ToString();
            Match1A.IsEnabled = false;
            Match1B.IsEnabled = false;
            Update();
        }

        void Match2a(object sender, System.EventArgs e)
        {

            Match2A.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[0].Wins++;
            Constants.Entrants[2].Losses++;
            Wins0.Text = Constants.Entrants[0].Wins.ToString();
            Losses2.Text = Constants.Entrants[2].Losses.ToString();
            Match2A.IsEnabled = false;
            Match2B.IsEnabled = false;
            Update();
        }

        void Match2b(object sender, System.EventArgs e)
        {
            Match2B.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[2].Wins++;
            Constants.Entrants[0].Losses++;
            Wins2.Text = Constants.Entrants[2].Wins.ToString();
            Losses0.Text = Constants.Entrants[0].Losses.ToString();
            Match2A.IsEnabled = false;
            Match2B.IsEnabled = false;
            Update();
        }

        void Match3a(object sender, System.EventArgs e)
        {
            Match3A.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[1].Wins++;
            Constants.Entrants[3].Losses++;
            Wins1.Text = Constants.Entrants[1].Wins.ToString();
            Losses3.Text = Constants.Entrants[3].Losses.ToString();
            Match3A.IsEnabled = false;
            Match3B.IsEnabled = false;
        }

        void Match3b(object sender, System.EventArgs e)
        {

            Match3B.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[3].Wins++;
            Constants.Entrants[1].Losses++;
            Wins3.Text = Constants.Entrants[3].Wins.ToString();
            Losses1.Text = Constants.Entrants[1].Losses.ToString();
            Match3A.IsEnabled = false;
            Match3B.IsEnabled = false;
            Update();
        }

        void Match4a(object sender, System.EventArgs e)
        {

            Match4A.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[2].Wins++;
            Constants.Entrants[3].Losses++;
            Wins2.Text = Constants.Entrants[2].Wins.ToString();
            Losses3.Text = Constants.Entrants[3].Losses.ToString();
            Match4A.IsEnabled = false;
            Match4B.IsEnabled = false;
            Update();
        }

        void Match4b(object sender, System.EventArgs e)
        {
            Match4B.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[3].Wins++;
            Constants.Entrants[2].Losses++;
            Wins3.Text = Constants.Entrants[3].Wins.ToString();
            Losses2.Text = Constants.Entrants[2].Losses.ToString();
            Match4A.IsEnabled = false;
            Match4B.IsEnabled = false;
            Update();
        }


        void Match5a(object sender, System.EventArgs e)
        {

            Match5A.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[0].Wins++;
            Constants.Entrants[1].Losses++;
            Wins0.Text = Constants.Entrants[0].Wins.ToString();
            Losses1.Text = Constants.Entrants[1].Losses.ToString();
            Match5A.IsEnabled = false;
            Match5B.IsEnabled = false;
            Update();
        }

        void Match5b(object sender, System.EventArgs e)
        {
            Match5B.FontAttributes = FontAttributes.Bold;
            Constants.Entrants[1].Wins++;
            Constants.Entrants[0].Losses++;
            Wins1.Text = Constants.Entrants[1].Wins.ToString();
            Losses0.Text = Constants.Entrants[0].Losses.ToString();
            Match5A.IsEnabled = false;
            Match5B.IsEnabled = false;
            Update();
        }

    }
}