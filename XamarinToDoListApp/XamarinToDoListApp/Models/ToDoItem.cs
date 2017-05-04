using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinToDoListApp.Models
{
	public class ToDoItem
	{
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Task { get; set; }
		public DateTime DueDate { get; set; }
	}
}
