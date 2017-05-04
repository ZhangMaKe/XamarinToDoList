using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;
using XamarinToDoListApp.Database;
using XamarinToDoListApp.Interfaces;
using XamarinToDoListApp.Models;

namespace XamarinToDoListApp
{
	public partial class App : Application
	{
		static ToDoItemDatabase database;

		public App()
		{
			InitializeComponent();

			MainPage = new XamarinToDoListApp.MainPage();

			var item = new ToDoItem();
			item.Task = "task 1";

			Database.SaveItem(item);

			var items = Database.GetItems();

			string s = "";
		}

		public static ToDoItemDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new ToDoItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db"));
				}
				return database;
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			MobileCenter.Start("android=5ef74552-8ea7-4388-9a74-426d4078030d;" +
				   "ios={Your iOS App secret here}",
				   typeof(Analytics), typeof(Crashes));
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
