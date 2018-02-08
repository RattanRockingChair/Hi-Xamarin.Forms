using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottomTabBarDemo.Views;
using Xamarin.Forms;

namespace BottomTabBarDemo
{
	public partial class MainPage : ContentPage
	{
		private enum NavigationPage
		{
			eNull,
			eHome,
			eList,
			eAccount
		}

		private Views.ContentView1 _View1 = null;
		private Views.ContentView2 _View2 = null;
		private Views.ContentView3 _View3 = null;

		private NavigationPage Current { set; get; }

		public MainPage()
		{
			InitializeComponent();

			_View1 = new ContentView1();
			_View2 = new ContentView2();
			_View3 = new ContentView3();

			_HomeImg1.Source = "home1.png";
			_ListImg1.Source = "list1.png";
			_AccountImg1.Source = "account1.png";

			_HomeImg.Source = "home0.png";
			_ListImg.Source = "list0.png";
			_AccountImg.Source = "account0.png";

			var tapGestureRecognizer = new TapGestureRecognizer();

			tapGestureRecognizer.Tapped += OnTappedHome;
			_HomeImg.GestureRecognizers.Add(tapGestureRecognizer);

			tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += OnTappedList;
			_ListImg.GestureRecognizers.Add(tapGestureRecognizer);

			tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += OnTappedAccount;
			_AccountImg.GestureRecognizers.Add(tapGestureRecognizer);

			Navigate(NavigationPage.eHome);
		}

		private void OnTappedAccount(object sender, EventArgs e)
		{
			Navigate(NavigationPage.eAccount);
		}

		private void OnTappedList(object sender, EventArgs e)
		{
			Navigate(NavigationPage.eList);
		}

		private void OnTappedHome(object sender, EventArgs e)
		{
			Navigate(NavigationPage.eHome);
		}

		private void Navigate(NavigationPage nav)
		{
			if (Current == nav)
			{
				return;
			}

			View titleView = null;
			View contentView = null;

			if (NavigationPage.eHome == nav)
			{
				contentView = _View1;

				_HomeImg.IsVisible = false;
				_HomeImg1.IsVisible = true;

				_ListImg.IsVisible = true;
				_ListImg1.IsVisible = false;

				_AccountImg.IsVisible = true;
				_AccountImg1.IsVisible = false;
			}
			else if (NavigationPage.eList == nav)
			{
				contentView = _View2;

				_HomeImg.IsVisible = true;
				_HomeImg1.IsVisible = false;

				_ListImg.IsVisible = false;
				_ListImg1.IsVisible = true;

				_AccountImg.IsVisible = true;
				_AccountImg1.IsVisible = false;
			}
			else if (NavigationPage.eAccount == nav)
			{
				contentView = _View3;

				_HomeImg.IsVisible = true;
				_HomeImg1.IsVisible = false;

				_ListImg.IsVisible = true;
				_ListImg1.IsVisible = false;

				_AccountImg.IsVisible = false;
				_AccountImg1.IsVisible = true;
			}
			else
			{
				return;
			}

			Current = nav;

			if (_MidLayout.Children.Count > 0)
			{
				_MidLayout.Children.RemoveAt(0);
			}

			_MidLayout.Children.Add(contentView);
		}

	}
}
