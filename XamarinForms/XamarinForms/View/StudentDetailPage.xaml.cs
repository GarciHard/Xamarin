using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms
{
	public partial class StudentDetailPage : ContentPage
	{
		public StudentDetailPage(Student selectedStudent)
		{
			InitializeComponent();
			this.BindingContext = selectedStudent;
		}
	}
}
