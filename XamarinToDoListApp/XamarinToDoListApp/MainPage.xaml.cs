using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinToDoListApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			var items = new string[]
			{
				"item 1",
				"item 2",
				"item 3"
			};

			this.taskList.ItemsSource = items;
		}
	}
}
