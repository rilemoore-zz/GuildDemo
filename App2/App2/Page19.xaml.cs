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
    public partial class Page19 : ContentPage, IAnimationPage
    {
        public Page19()
        {
            InitializeComponent();
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
        private void P1Up(object sender, EventArgs e)
        {
            int newLife = 0;
            newLife = Int32.Parse(P1Life.Text);
            newLife++;
            P1Life.Text = newLife.ToString();
        }
        private void P1Down(object sender, EventArgs e)
        {
            int newLife = 0;
            newLife = Int32.Parse(P1Life.Text);
            newLife--;
            P1Life.Text = newLife.ToString();
        }
        private void P2Up(object sender, EventArgs e)
        {
            int newLife = 0;
            newLife = Int32.Parse(P2Life.Text);
            newLife++;
            P2Life.Text = newLife.ToString();
        }
        private void P2Down(object sender, EventArgs e)
        {
            int newLife = 0;
            newLife = Int32.Parse(P2Life.Text);
            newLife--;
            P2Life.Text = newLife.ToString();
        }

        /*private void Calc(object sender, EventArgs e)
        {
            if (P1Mod.Text == "")
            {
                P1Mod.Text = "0";
            }
            if (P2Mod.Text == "")
            {
                P2Mod.Text = "0";
            }
            int x = Int32.Parse(P1Life.Text);
            int y = Int32.Parse(P2Life.Text);
            int a = Int32.Parse(P1Mod.Text);
            int b = Int32.Parse(P2Mod.Text);
            x = x + a;
            y = y + b;
            P1Life.Text = x.ToString();
            P2Life.Text = y.ToString();
            P1Mod.Text = "0";
            P2Mod.Text = "0";
        }*/
    }
}