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
	public partial class Page4 : ContentPage, IAnimationPage
    {
		public Page4 ()
		{
			InitializeComponent ();
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

        private void D20(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 21);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");         
        }

        private void D2(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 3);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }

        private void D3(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 4);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }


        private void D4(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 5);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }

        private void D6(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 7);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }

        private void D8(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 9);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }

        private void D10(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 11);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }

        private void D12(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 13);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }

        private void D100(object sender, System.EventArgs e)
        {
            int num;
            Random random = new Random();
            num = random.Next(1, 101);
            DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
        }

        private void Custom(object sender, System.EventArgs e)
        {
            if(Max.Text != "" && Min.Text != "")
            {
                int num;
                int max = Int32.Parse(Max.Text);
                int min = Int32.Parse(Min.Text);
                if (max >= min)
                {
                    Random random = new Random();
                    num = random.Next(min, max);
                    DisplayAlert("You Rolled a", num.ToString(), "Thank you dice roller");
                }
            }
        }
    }
}