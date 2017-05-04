using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinToDoListApp.Interfaces;
using XamarinToDoListApp.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency (typeof (FileHelper))]
namespace XamarinToDoListApp.Droid
{
	public class FileHelper : IFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			return Path.Combine(path, filename);
		}
	}
}