﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using App2.Stuff;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;


namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page26 : ContentPage, IAnimationPage
    {
        public Page26()
        {
            InitializeComponent();
            this.BackgroundImage = "smallbackground.png";
            GetEvents();
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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //this.Title.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
        }

        public List<GameEvent> events = new List<GameEvent>();
        async void GetEvents()
        {
            events = await App.RestService.GetResponse<List<GameEvent>>(Constants.LoginUrl);
            Title.Text = events[6].EventTitle;
            Date.Text = events[6].EventDate;
            StartTime.Text = events[6].StartTime.ToString();
            EndTime.Text = events[6].EndTime.ToString();
            // UserId.Text = events[6].UserId.ToString();
            Game.Text = events[6].EventGame;
            Platform.Text = events[6].Platform;
            //NumPlayers.Text = events[6].numberOfPlayers.ToString();

        }

    }
}