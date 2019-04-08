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
	public partial class DoubleElim : ContentPage, IAnimationPage
    {
		public DoubleElim ()
		{
            InitializeComponent();
            this.BackgroundImage = "smallbackground.png";
            BindingContext = this;
            a.Text = Constants.Entrants[0].Name;
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

        void Handle_ClickedA(object sender, System.EventArgs e)
        {

        }

        void Handle_ClickedB(object sender, System.EventArgs e)
        {

        }

        void Handle_ClickedC(object sender, System.EventArgs e)
        {

        }

        void Handle_ClickedD(object sender, System.EventArgs e)
        {

        }

        void Handle_ClickedE(object sender, System.EventArgs e)
        {

        }

        void Handle_ClickedF(object sender, System.EventArgs e)
        {

        }

        void Handle_ClickedG(object sender, System.EventArgs e)
        {

        }

        void Handle_ClickedH(object sender, System.EventArgs e)
        {

        }
    }
}