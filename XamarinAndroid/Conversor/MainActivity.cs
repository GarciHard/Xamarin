using Android.App;
using Android.Widget;
using Android.OS;

namespace Conversor
{
	[Activity(Label = "Conversor", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			Button btnConvert = FindViewById<Button>(
				Resource.Id.btnConvertir
			);
			EditText txtDollar = FindViewById<EditText>(
				Resource.Id.txtDolares
			);
			EditText txtMxPesos = FindViewById<EditText>(
				Resource.Id.txtPesos
			);
			double v_dolares, v_pesos;
			btnConvert.Click += delegate
			{
				try
				{
					v_dolares = double.Parse(txtDollar.Text);
					v_pesos = v_dolares * 19.85;
					txtMxPesos.Text = v_pesos.ToString();

				}
				catch (System.Exception e)
				{
					Toast.MakeText(this, e.Message,
								   ToastLength.Short).Show();
				}
			};
		}
	}
}

