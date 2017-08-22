using System;
using Xamarin.Forms;

namespace XamarinForms
{
	public partial class XamarinFormsPage : ContentPage
	{
		public XamarinFormsPage()
		{
			InitializeComponent();
			this.BindingContext = new StudentDirectoryVM();
			lvStudents.ItemSelected += LvStudents_ItemSelected;
		}

		void LvStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Student selectedStudent = (Student)e.SelectedItem;
			if (selectedStudent == null)
				return;
			Navigation.PushAsync(new StudentDetailPage(selectedStudent));
			lvStudents.SelectedItem = null;
		}
	}
}
