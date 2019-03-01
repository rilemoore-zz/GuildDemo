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
	public partial class Page18 : ContentPage, IAnimationPage
    {
        public Page18()
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

        private void Calc(object sender, EventArgs e)
        {
            if(P1Mod.Text=="" )
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
        }
    }
}