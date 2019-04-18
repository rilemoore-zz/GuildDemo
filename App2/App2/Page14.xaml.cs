using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page14 : ContentPage, IAnimationPage
    {
        public Page14()
        {
            //public int ban { get; set; }
            InitializeComponent();
            //Initiative();
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


        /* void Initiative()
         {
             if(ban == 0 || ban == 3)
             {
                 Banthingy.Text = "Player 1 strike";
             }
             if(ban == 1 || ban == 2)
             {
                 Banthingy.Text = "Player 2 strike";
             }
             else
             {
                 Banthingy.Text = "Stage Decided!";
             }
         }*/
        void BF1(object sender, System.EventArgs e)
        {
            BF.IsEnabled = false;

            
        }
        void FD1(object sender, System.EventArgs e)
        {
            FD.IsEnabled = false;
           
        }
        void SV1(object sender, System.EventArgs e)
        {
            SV.IsEnabled = false;

        }
        void PS21(object sender, System.EventArgs e)
        {
            PS2.IsEnabled = false;

        }
        void LC1(object sender, System.EventArgs e)
        {
            LC.IsEnabled = false;

        }
        void CS1(object sender, System.EventArgs e)
        {
            CS.IsEnabled = false;
        }
        void Unova1(object sender, System.EventArgs e)
        {
            Unova.IsEnabled = false;
        }
        void TC1(object sender, System.EventArgs e)
        {
            TC.IsEnabled = false;
        }
        void YS1(object sender, System.EventArgs e)
        {
            YS.IsEnabled = false;
        }
        void YI1(object sender, System.EventArgs e)
        {
            YI.IsEnabled = false;
        }
        void Kalos1(object sender, System.EventArgs e)
        {
            Kalos.IsEnabled = false;
        }
        void Refresh(object sender, System.EventArgs e)
        {
            BF.Text = "Battlefield";
            FD.Text = "Final Destination";
            SV.Text = "Smashville";
            PS2.Text = "Pokemon Stadium 2";
            LC.Text = "Lylat Cruise";
            CS.Text = "Castle Siege";
            Unova.Text = "Unova Pokemon League";
            TC.Text = "Town and City";
            YS.Text = "Yoshi's Story";
            YI.Text = "Yoshi's Island";
            Kalos.Text = "Kalos Pokemon League";
            BF.IsEnabled = true;
            FD.IsEnabled = true;
            SV.IsEnabled = true;
            PS2.IsEnabled = true;
            LC.IsEnabled = true;
            TC.IsEnabled = true;
            CS.IsEnabled = true;
            Unova.IsEnabled = true;
            YS.IsEnabled = true;
            YI.IsEnabled = true;
            Kalos.IsEnabled = true;
        }

        void Frostbite(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Frostbite());
        }

    }
}