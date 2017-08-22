using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinForms
{
	public class StudentDirectoryVM : ObservableBaseObject
	{
		public ObservableCollection<Student> Students { get; set; }

		bool isBusy = false;

		public bool IsBusy
		{
			get { return isBusy; }
			set
			{
				isBusy = value;
				onPropertyChange();
			}
		}

		public Command LoadDirectoryCommand { get; set; }

		public StudentDirectoryVM()
		{
			Students = new ObservableCollection<Student>();
			IsBusy = false;
			LoadDirectoryCommand = new Command((obj) => LoadDirectory());
		}

		async void LoadDirectory()
		{
			if (!IsBusy)
			{
				isBusy = true;
				await Task.Delay(3000);

				var loadedDirectory = StudentDirectoryService.LoadStudentDirectory();
				foreach (var student in loadedDirectory.Students)
				{
					Students.Add(student);
				}
				isBusy = false;
			}
		}
	}
}
