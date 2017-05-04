using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinToDoListApp.Interfaces;
using XamarinToDoListApp.Models;

namespace XamarinToDoListApp.Database
{

    public class ToDoItemDatabase
    {
        public SQLiteConnection database;

        public ToDoItemDatabase(string dbPath)
        {
            try
            {
                database = new SQLiteConnection(dbPath);
                database.CreateTable<ToDoItem>();
            }
            catch (Exception ex)
            {
                var s = ex.Message;
                throw;
            }
        }

        public List<ToDoItem> GetItems()
        {
            return database.Table<ToDoItem>().ToList();
        }

        public int SaveItem(ToDoItem item)
        {
            return database.Insert(item);
        }
    }
}
