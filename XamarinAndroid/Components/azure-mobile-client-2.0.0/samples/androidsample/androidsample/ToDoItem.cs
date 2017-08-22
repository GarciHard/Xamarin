using System;
using Newtonsoft.Json;

namespace androidsample
{
	public class ToDoItem
	{
		public string Id { get; set; }

		[JsonProperty(PropertyName = "nombre")]
		public string Nombre = "Jorge";

		[JsonProperty(PropertyName = "texto")]
		public string Text { get; set; }

		[JsonProperty(PropertyName = "completado")]
		public bool Complete { get; set; }
	}

	public class ToDoItemWrapper : Java.Lang.Object
	{
		public ToDoItemWrapper (ToDoItem item)
		{
			ToDoItem = item;
		}

		public ToDoItem ToDoItem { get; private set; }
	}
}

