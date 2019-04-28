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
	public partial class SingleElim16 : ContentPage, IAnimationPage
    {
		public SingleElim16 ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
            BindingContext = this;
            one_zero.Text = Constants.Entrants[0].Name;
            two_zero.Text = Constants.Entrants[15].Name;
            five_zero.Text = Constants.Entrants[7].Name;
            six_zero.Text = Constants.Entrants[8].Name;
            eight_zero.Text = Constants.Entrants[4].Name;
            nine_zero.Text = Constants.Entrants[11].Name;
            twelve_zero.Text = Constants.Entrants[3].Name;
            thirteen_zero.Text = Constants.Entrants[12].Name;
            fifteen_zero.Text = Constants.Entrants[2].Name;
            sixteen_zero.Text = Constants.Entrants[13].Name;
            nineteen_zero.Text = Constants.Entrants[5].Name;
            twenty_zero.Text = Constants.Entrants[10].Name;
            twentytwo_zero.Text = Constants.Entrants[6].Name;
            twentythree_zero.Text = Constants.Entrants[9].Name;
            twentysix_zero.Text = Constants.Entrants[1].Name;
            twentyseven_zero.Text = Constants.Entrants[14].Name;

            if(two_zero.Text == "BYE")
            {
                three_one.Text = one_zero.Text;
                one_zero.IsEnabled = false;
                two_zero.IsEnabled = false;
            }
            if (six_zero.Text == "BYE")
            {
                four_one.Text = five_zero.Text;
                five_zero.IsEnabled = false;
                six_zero.IsEnabled = false;
            }
            if (nine_zero.Text == "BYE")
            {
                ten_one.Text = eight_zero.Text;
                eight_zero.IsEnabled = false;
                nine_zero.IsEnabled = false;
            }
            if (thirteen_zero.Text == "BYE")
            {
                eleven_one.Text = twelve_zero.Text;
                twelve_zero.IsEnabled = false;
                thirteen_zero.IsEnabled = false;
            }
            if (sixteen_zero.Text == "BYE")
            {
                seventeen_one.Text = fifteen_zero.Text;
                fifteen_zero.IsEnabled = false;
                sixteen_zero.IsEnabled = false;
            }
            if (twenty_zero.Text == "BYE")
            {
                eighteen_one.Text = nineteen_zero.Text;
                twenty_zero.IsEnabled = false;
                nineteen_zero.IsEnabled = false;
            }
            if (twentythree_zero.Text == "BYE")
            {
                twentyfour_one.Text = twentytwo_zero.Text;
                twentytwo_zero.IsEnabled = false;
                twentythree_zero.IsEnabled = false;
            }
            if (twentyseven_zero.Text == "BYE")
            {
                twentyfive_one.Text = twentysix_zero.Text;
                twentysix_zero.IsEnabled = false;
                twentyseven_zero.IsEnabled = false;
            }

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

        void fifteen_zeroa(object sender, System.EventArgs e)
        {
            seventeen_one.Text = fifteen_zero.Text;
            fifteen_zero.IsEnabled = false;
            sixteen_zero.IsEnabled = false;
        }

        void sixteen_zeroa(object sender, System.EventArgs e)
        {
            seventeen_one.Text = sixteen_zero.Text;
            fifteen_zero.IsEnabled = false;
            sixteen_zero.IsEnabled = false;
        }

        void seventeen_onea(object sender, System.EventArgs e)
        {
            twenty_two.Text = seventeen_one.Text;
            seventeen_one.IsEnabled = false;
            eighteen_one.IsEnabled = false;
        }

        void eighteen_onea(object sender, System.EventArgs e)
        {
            twenty_two.Text = eighteen_one.Text;
            seventeen_one.IsEnabled = false;
            eighteen_one.IsEnabled = false;
        }

        void twenty_zeroa(object sender, System.EventArgs e)
        {
            eighteen_one.Text = twenty_zero.Text;
            twenty_zero.IsEnabled = false;
            nineteen_zero.IsEnabled = false;
        }

        void nineteen_zeroa(object sender, System.EventArgs e)
        {
            eighteen_one.Text = nineteen_zero.Text;
            twenty_zero.IsEnabled = false;
            nineteen_zero.IsEnabled = false;
        }

        void twentytwo_zeroa(object sender, System.EventArgs e)
        {
            twentyfour_one.Text = twentytwo_zero.Text;
            twentytwo_zero.IsEnabled = false;
            twentythree_zero.IsEnabled = false;
        }

        void twentythree_zeroa(object sender, System.EventArgs e)
        {
            twentyfour_one.Text = twentythree_zero.Text;
            twentytwo_zero.IsEnabled = false;
            twentythree_zero.IsEnabled = false;
        }

        void twentyfour_onea(object sender, System.EventArgs e)
        {
            twentytwo_two.Text = twentyfour_one.Text;
            twentyfour_one.IsEnabled = false;
            twentyfive_one.IsEnabled = false;
        }

        void twentyfive_onea(object sender, System.EventArgs e)
        {
            twentytwo_two.Text = twentyfive_one.Text;
            twentyfour_one.IsEnabled = false;
            twentyfive_one.IsEnabled = false;
        }

        void twentysix_zeroa(object sender, System.EventArgs e)
        {
            twentyfive_one.Text = twentysix_zero.Text;
            twentysix_zero.IsEnabled = false;
            twentyseven_zero.IsEnabled = false;

        }

        void twentyseven_zeroa(object sender, System.EventArgs e)
        {
            twentyfive_one.Text = twentyseven_zero.Text;
            twentysix_zero.IsEnabled = false;
            twentyseven_zero.IsEnabled = false;
        }

        void six_twoa(object sender, System.EventArgs e)
        {
            thirteen_three.Text = six_two.Text;
            six_two.IsEnabled = false;
            eight_two.IsEnabled = false;
        }

        void eight_twoa(object sender, System.EventArgs e)
        {
            thirteen_three.Text = eight_two.Text;
            six_two.IsEnabled = false;
            eight_two.IsEnabled = false;
        }

        void twenty_twoa(object sender, System.EventArgs e)
        {
            fourteen_three.Text = twenty_two.Text;
            twenty_two.IsEnabled = false;
            twentytwo_two.IsEnabled = false;

        }

        void twentytwo_twoa(object sender, System.EventArgs e)
        {
            fourteen_three.Text = twentytwo_two.Text;
            twenty_two.IsEnabled = false;
            twentytwo_two.IsEnabled = false;
        }

        void thirteen_threea(object sender, System.EventArgs e)
        {
            fourteen_four.Text = thirteen_three.Text;
            DisplayAlert(fourteen_four.Text + " is your Grand Champion!", "", "Continue");
            thirteen_three.IsEnabled = false;
            fourteen_three.IsEnabled = false;
        }

        void fourteen_threea(object sender, System.EventArgs e)
        {
            fourteen_four.Text = fourteen_three.Text;
            DisplayAlert(fourteen_four.Text + " is your Grand Champion!", "", "Continue");
            thirteen_three.IsEnabled = false;
            fourteen_three.IsEnabled = false;
            
        }
        void fourteen_foura(object sender, System.EventArgs e)
        {
            DisplayAlert(fourteen_four.Text + " is your Grand Champion!", "", "Continue");
        }

    }

}
