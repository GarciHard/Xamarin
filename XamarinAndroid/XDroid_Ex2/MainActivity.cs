using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using SQLite;
using System.IO;

namespace XDroid_Ex2
{
	[Activity(Label = "CapitalCont", MainLauncher = true)]
	public class MainActivity : Activity
	{
		double capitalMexico, capitalColombia;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			path = Path.Combine(path, "Base.db3");
			var conn = new SQLiteConnection(path);
			conn.CreateTable<Informacion>();

			EditText txtInMx = FindViewById<EditText>(
				Resource.Id.txtInMexico
			);
			EditText txtOutMx = FindViewById<EditText>(
				Resource.Id.txtOutMexico
			);

			EditText txtInCo = FindViewById<EditText>(
				Resource.Id.txtInColombia
			);
			EditText txtOutCo = FindViewById<EditText>(
				Resource.Id.txtOutColombia
			);

			Button btnCalcular = FindViewById<Button>(
				Resource.Id.btnCalcular
			);

			btnCalcular.Click += delegate
			{
				try
				{
					double inMexico = double.Parse(txtInMx.Text);
					double outMexico = double.Parse(txtOutMx.Text);
					double inColombia = double.Parse(txtInCo.Text);
					double outColombia = double.Parse(txtOutCo.Text);

					capitalMexico = inMexico - outMexico;
					capitalColombia = inColombia - outColombia;

					var insertInfo = new Informacion();
					insertInfo.ingresosMexico = inMexico;
					insertInfo.ingresosColombia = inColombia;
					insertInfo.egresosMexico = capitalMexico;
					insertInfo.egresosColombia = capitalColombia;
					conn.Insert(insertInfo);
					Toast.MakeText(this, "Guardado en SQLite",
					               ToastLength.Long).Show();
					cargarDatos();
				}
				catch (System.Exception ex)
				{
					Toast.MakeText(this, ex.Message,
								   ToastLength.Short).Show();
				}
			};
		}
		void cargarDatos()
		{
			Intent intentObj = new Intent(this,
									  typeof(CapitalActivity));
			intentObj.PutExtra("capitalM", capitalMexico);
			intentObj.PutExtra("capitalC", capitalColombia);
			StartActivity(intentObj);
		}
	}
	public class Informacion
	{
		public double ingresosMexico { get; set; }
		public double ingresosColombia { get; set; }
		public double egresosMexico { get; set; }
		public double egresosColombia { get; set;}
	}
}