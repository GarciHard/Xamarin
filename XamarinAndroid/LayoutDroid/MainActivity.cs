using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Content;

namespace LayoutDroid
{
	[Activity(Label = "LayoutDroid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			Button btnLinearLayout = FindViewById<Button>(Resource.Id.btnLinear);
			Button btnRelativeLayout = FindViewById<Button>(Resource.Id.btnRelative);
			Button btnListView = FindViewById<Button>(Resource.Id.btnListView);

			btnLinearLayout.Click += delegate {
				linearLayout();
			};
			btnRelativeLayout.Click += delegate{
				relativeLayout();
			};
			btnListView.Click += delegate
			{
				listView();
			};
		}

		void linearLayout()
		{
			Intent linearObj = new Intent(this,
			                              typeof(LinearActivity));
			StartActivity(linearObj);
		}

		void relativeLayout()
		{
			Intent relativeObj = new Intent(this,
			                                typeof(RelativeActivity));
			StartActivity(relativeObj);
		}

		void listView()
		{
			Intent listViewObj = new Intent(this,
			                                typeof(ListViewActivity));
			StartActivity(listViewObj);
		}

	}
}

