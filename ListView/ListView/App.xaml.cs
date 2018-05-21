using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListView
{
	public partial class App : Application
	{
        public static MasterDetailPage MasterD { get; set; }
            
		public App()
		{
			InitializeComponent();
            MainPage = new MainPage();


        }




        protected override void OnStart ()
		{
            
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
