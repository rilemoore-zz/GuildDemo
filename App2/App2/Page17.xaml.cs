using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Stuff;

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
            var list = new List<InitiativeClass>();

            /* for(int i = 0; i<8; i++)
             {
                 list.Add(.Text);
             }*/
             for(int i = 0; i < 8; i++)
            {
                list.Add(new InitiativeClass());
            }
            list[0].name = Init0Name.Text;
            list[0].initiative = Int32.Parse(Init0.Text);
            list[1].name = Init1Name.Text;
            list[1].initiative = Int32.Parse(Init1.Text);
            list[2].name = Init2Name.Text;
            list[2].initiative = Int32.Parse(Init2.Text);
            list[3].name = Init3Name.Text;
            list[3].initiative = Int32.Parse(Init3.Text);
            list[4].name = Init4Name.Text;
            list[4].initiative = Int32.Parse(Init4.Text);
            list[5].name = Init5Name.Text;
            list[5].initiative = Int32.Parse(Init5.Text);
            list[6].name = Init6Name.Text;
            list[6].initiative = Int32.Parse(Init6.Text);
            list[7].name = Init7Name.Text;
            list[7].initiative = Int32.Parse(Init7.Text);

            list[0].Sortyboy(list);
            /*list.Add(Init1.Text);
            list.Add(Init2.Text);
            list.Add(Init3.Text);
            list.Add(Init4.Text);
            list.Add(Init5.Text);
            list.Add(Init6.Text);
            list.Add(Init7.Text);
            list.Add(Init8.Text);*/
            //DisplayAlert("Element 1: ", list[0], "thanks");
            Init0.Text = list[0].initiative.ToString();
            Init0Name.Text = list[0].name;
            Init1.Text = list[1].initiative.ToString();
            Init0Name.Text = list[1].name;
            Init2.Text = list[2].initiative.ToString();
            Init0Name.Text = list[2].name;
            Init3.Text = list[3].initiative.ToString();
            Init0Name.Text = list[3].name;
            Init4.Text = list[4].initiative.ToString();
            Init0Name.Text = list[4].name;
            Init5.Text = list[5].initiative.ToString();
            Init0Name.Text = list[5].name;
            Init6.Text = list[6].initiative.ToString();
            Init0Name.Text = list[6].name;
            Init7.Text = list[7].initiative.ToString();
            Init0Name.Text = list[7].name;

        }
    }
}