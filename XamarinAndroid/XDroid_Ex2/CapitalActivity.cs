using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System.IO;
using SQLite;

namespace XDroid_Ex2
{
	[Activity(Label = "CapitalActivity")]
	public class CapitalActivity : Activity
	{
		double defaultValue = 0;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.ViewCapital);

			Button btnSalir = FindViewById<Button>(
				Resource.Id.btnSalir
			);

			EditText txtCapitalM = FindViewById<EditText>(
				Resource.Id.txtCapitalM
			);
			EditText txtCapitalC = FindViewById<EditText>(
				Resource.Id.txtCapitalC
			);

			ImageView imgMx = FindViewById<ImageView>(
				Resource.Id.imgM
			);
			ImageView imgCo = FindViewById<ImageView>(
				Resource.Id.imgC
			);

			try
			{
				txtCapitalM.Text = Intent.GetDoubleExtra("capitalM", defaultValue).ToString();
				txtCapitalC.Text = Intent.GetDoubleExtra("capitalC", defaultValue).ToString();

				imgMx.SetImageResource(Resource.Drawable.ImgMx);
				imgCo.SetImageResource(Resource.Drawable.ImgCol);

				var path = System.Environment.GetFolderPath(
					System.Environment.SpecialFolder.Personal);
				path = Path.Combine(path, "Base.db3");
				var conn = new SQLiteConnection(path);
				var elementos = from s in conn.Table<Informacion>() select s;
				foreach (var fila in elementos)
				{
					Toast.MakeText(this, fila.ingresosMexico.ToString(),
					               ToastLength.Long).Show();
					Toast.MakeText(this, fila.ingresosColombia.ToString(),
								   ToastLength.Long).Show();
					
					Toast.MakeText(this, fila.egresosMexico.ToString(),
								   ToastLength.Long).Show();
					Toast.MakeText(this, fila.egresosColombia.ToString(),
								   ToastLength.Long).Show();
				}


			}
			catch (System.Exception ex)
			{
				Toast.MakeText(this, ex.Message,
								   ToastLength.Short).Show();
			}

			btnSalir.Click += delegate {
				Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
			};
		}
	}
}
