﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XamarinToDoListApp.Interfaces;
using XamarinToDoListApp.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (FileHelper))]
namespace XamarinToDoListApp.iOS
{
	public class FileHelper : IFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}

			return Path.Combine(libFolder, filename);
		}
	}
}
