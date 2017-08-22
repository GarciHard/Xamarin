using System;

namespace XamarinForms
{
	public class Student : ObservableBaseObject
	{
		private string name;
		private string lastName;
		private string group;
		private string studentNumber;
		private double average;

		public string Name
		{
			get { return name; }
			set { name = value; onPropertyChange(); }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; onPropertyChange(); }
		}

		public string Group
		{
			get { return group; }
			set { group = value; onPropertyChange(); }
		}

		public string StudentNumber
		{
			get { return studentNumber; }
			set { studentNumber = value; onPropertyChange(); }
		}

		public double Average
		{
			get { return average; }
			set { average = value; onPropertyChange(); }
		}
	}
}
