﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestApp_VersionControl_1
{
	[Activity (Label = "TestApp_VersionControl_1", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}

		public void TestClass1 ()
		{
			Console.WriteLine ("Test Name");
		}

		public void TestClass2 ()
		{
			Console.WriteLine ("Test Name");
		}

		public void TestClass3 ()
		{
			Console.WriteLine ("Test Name");
		}
	}
}


