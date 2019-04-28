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
	public partial class SingleElim8 : ContentPage, IAnimationPage
    {
		public SingleElim8 ()
		{
			InitializeComponent ();

            this.BackgroundImage = "smallbackground.png";
            BindingContext = this;
            one_zero.Text = Constants.Entrants[0].Name;
            two_zero.Text = Constants.Entrants[7].Name;
            five_zero.Text = Constants.Entrants[3].Name;
            six_zero.Text = Constants.Entrants[4].Name;
            eight_zero.Text = Constants.Entrants[2].Name;
            nine_zero.Text = Constants.Entrants[5].Name;
            twelve_zero.Text = Constants.Entrants[1].Name;
            thirteen_zero.Text = Constants.Entrants[6].Name;
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

        void one_zeroa(object sender, System.EventArgs e)
        {
            three_one.Text = one_zero.Text;
            one_zero.IsEnabled = false;
            two_zero.IsEnabled = false;

        }

        void two_zeroa(object sender, System.EventArgs e)
        {
            three_one.Text = two_zero.Text;
            two_zero.IsEnabled = false;
            one_zero.IsEnabled = false;

        }

        void three_onea(object sender, System.EventArgs e)
        {
            six_two.Text = three_one.Text;
            three_one.IsEnabled = false;
            four_one.IsEnabled = false;
        }

        void four_onea(object sender, System.EventArgs e)
        {
            six_two.Text = four_one.Text;
            three_one.IsEnabled = false;
            four_one.IsEnabled = false;
        }

        void five_zeroa(object sender, System.EventArgs e)
        {
            four_one.Text = five_zero.Text;
            five_zero.IsEnabled = false;
            six_zero.IsEnabled = false;
        }

        void six_zeroa(object sender, System.EventArgs e)
        {
            four_one.Text = six_zero.Text;
            six_zero.IsEnabled = false;
        }

        void ten_onea(object sender, System.EventArgs e)
        {
            eight_two.Text = ten_one.Text;
            ten_one.IsEnabled = false;
            eleven_one.IsEnabled = false;
        }

        void eight_zeroa(object sender, System.EventArgs e)
        {
            ten_one.Text = eight_zero.Text;
            eight_zero.IsEnabled = false;
            nine_zero.IsEnabled = false;
        }

        void nine_zeroa(object sender, System.EventArgs e)
        {
            ten_one.Text = nine_zero.Text;
            eight_zero.IsEnabled = false;
            nine_zero.IsEnabled = false;
        }

        void eleven_onea(object sender, System.EventArgs e)
        {
            eight_two.Text = eleven_one.Text;
            ten_one.IsEnabled = false;
            eleven_one.IsEnabled = false;
        }

        void twelve_zeroa(object sender, System.EventArgs e)
        {
            eleven_one.Text = twelve_zero.Text;
            twelve_zero.IsEnabled = false;
            thirteen_zero.IsEnabled = false;
        }

        void thirteen_zeroa(object sender, System.EventArgs e)
        {
            eleven_one.Text = thirteen_zero.Text;
            twelve_zero.IsEnabled = false;
            thirteen_zero.IsEnabled = false;
        }


        void six_twoa(object sender, System.EventArgs e)
        {
            thirteen_three.Text = six_two.Text;
            DisplayAlert(six_two.Text + " is your Grand Champion!", "", "Continue");
            six_two.IsEnabled = false;
            eight_two.IsEnabled = false;
        }

        void eight_twoa(object sender, System.EventArgs e)
        {
            thirteen_three.Text = eight_two.Text;
            DisplayAlert(eight_two.Text + " is your Grand Champion!", "", "Continue");
            six_two.IsEnabled = false;
            eight_two.IsEnabled = false;
        }

    }
}