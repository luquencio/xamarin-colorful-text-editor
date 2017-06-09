﻿using Xamarin.Forms;

namespace colorfultexteditor
{
    public partial class App : Application
    {
        public App()
        {
			InitializeComponent();

			//var page = new TabbedPage();
            MainPage = new NavigationPage(new EditorPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
