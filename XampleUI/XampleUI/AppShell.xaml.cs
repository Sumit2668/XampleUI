﻿using System;
using Xamarin.Forms;
using XampleUI.Views;
using XampleUI.Views.DribCakes;

namespace XampleUI
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
			Routing.RegisterRoute(nameof(DribCakes), typeof(DribCakes));
			Routing.RegisterRoute(nameof(CakeList), typeof(CakeList));
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}
	}
}