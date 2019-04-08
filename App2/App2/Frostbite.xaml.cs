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
    public partial class Frostbite : ContentPage, IAnimationPage
    {
        public Frostbite()
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

        void Genesix(object sender, System.EventArgs e)
        {

            Navigation.PopAsync();
        }

        void BF1(object sender, System.EventArgs e)
        {
            BF.Text = "";

        }
        void FD1(object sender, System.EventArgs e)
        {
            FD.Text = "";

        }
        void SV1(object sender, System.EventArgs e)
        {
            SV.Text = "";

        }
        void PS21(object sender, System.EventArgs e)
        {
            PS2.Text = "";

        }
        void LC1(object sender, System.EventArgs e)
        {
            LC.Text = "";

        }

        void TC1(object sender, System.EventArgs e)
        {
            TC.Text = "";
        }
        void YS1(object sender, System.EventArgs e)
        {
            YS.Text = "";
        }
        void YI1(object sender, System.EventArgs e)
        {
            YI.Text = "";
        }
        void Kalos1(object sender, System.EventArgs e)
        {
            Kalos.Text = "";
        }
        void Refresh(object sender, System.EventArgs e)
        {
            BF.Text = "Battlefield";
            FD.Text = "Final Destination";
            SV.Text = "Smashville";
            PS2.Text = "Pokemon Stadium 2";
            LC.Text = "Lylat Cruise";
            TC.Text = "Town and City";
            YS.Text = "Yoshi's Story";
            YI.Text = "Yoshi's Island";
            Kalos.Text = "Kalos Pokemon League";
        }

    }
}