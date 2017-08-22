using Android.App;
using Android.OS;
using Android.Widget;

namespace LayoutDroid
{
	[Activity(Label = "ListViewActivity")]
	public class ListViewActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.ListView);
			EmpleadoList empList = new EmpleadoList();
			var empleados = empList.obtenerEmpleados(30);

			ListView lvEmpleados = FindViewById<ListView>(Resource.Id.lvEmpleados);
			ArrayAdapter<Empleado> adapter = new ArrayAdapter<Empleado>(this,
			                                                            Android.Resource.Layout.SimpleListItem1,
			                                                            empleados);
			lvEmpleados.Adapter = adapter;
		}
	}
}
