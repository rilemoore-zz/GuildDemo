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
	public partial class Page17 : ContentPage, IAnimationPage
    {
		public Page17 ()
        {
            InitializeComponent();
            this.BackgroundImage = "smallbackground.png";
            //var list = new List<Page17>();
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

        private void Sort(object sender, System.EventArgs e)
        {
            var list = new List<string>();
            /* for(int i = 0; i<8; i++)
             {
                 list.Add(.Text);
             }*/
            list.Add(Init1.Text);
            list.Add(Init2.Text);
            list.Add(Init3.Text);
            list.Add(Init4.Text);
            list.Add(Init5.Text);
            list.Add(Init6.Text);
            list.Add(Init7.Text);
            list.Add(Init8.Text);
            list.Sort();
            DisplayAlert("Element 1: ", list[0], "thanks");
            Init1.Text = list[0];
            Init2.Text = list[1];
            Init3.Text = list[2];
            Init4.Text = list[3];
            Init5.Text = list[4];
            Init6.Text = list[5];
            Init7.Text = list[6];
            Init8.Text = list[7];

        }
    }
}