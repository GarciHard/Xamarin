using System;
namespace LayoutDroid
{
	public class Empleado
	{

		public override string ToString()
		{
			return Nombre;
		}

		private string nombre;
		public string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				nombre = value;
			}
		}
		private string posicion;
		public string Posicion
		{
			get
			{
				return posicion;
			}
			set
			{
				posicion = value;
			}
		}
		private string email;
		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

		public Empleado(string nombre, string posicion, string email)
		{
			Nombre = nombre;
			Posicion = posicion;
			Email = email;
		}
	}
		public class EmpleadoList
		{
			public Empleado[] obtenerEmpleados(int numero)
			{
				Empleado[] empObj = new Empleado[numero];
				String[] posiciones = { "Supervisor", "Operador", "Gerente", "Director" };
				Random rdn = new Random();

				for (int i = 0; i < numero; i++)
				{
					var nombre = Guid.NewGuid().ToString().Substring(0, 10);

					var nvoEmpleado = new Empleado(nombre,
												   posiciones[rdn.Next(0, 3)],
												   nombre + "xamarin.com"
												  );
					empObj[i] = nvoEmpleado;
				}
				return empObj;
			}
		}


}