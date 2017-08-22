﻿using Xamarin.Forms;

namespace XamarinFormRESTJSON
{
	public partial class App : Application
	{
		private MainPage _mainPage;
		public App()
		{
			_mainPage = new XamarinFormRESTJSON.MainPage();
			InitializeComponent();

			MainPage = _mainPage;
		}

		protected override void OnStart()
		{
			_mainPage.Load();
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
