﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace bragit
{
	[Activity(Label = "bragit", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			int x = 25;
			x++;
		}
	}
}

