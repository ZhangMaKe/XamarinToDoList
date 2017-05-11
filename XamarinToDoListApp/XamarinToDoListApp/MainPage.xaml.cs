using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinToDoListApp.Database;
using XamarinToDoListApp.Interfaces;

namespace XamarinToDoListApp
{
	public partial class MainPage : ContentPage
	{
        static ToDoItemDatabase database;
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
        public MainPage()
		{
			InitializeComponent();

            var items = Database.GetItems();
            var itemNames = new List<string>();

            foreach (var item in items)
            {
                itemNames.Add(item.Task);
            }

            taskList.ItemsSource = items;
		}
	}
}
