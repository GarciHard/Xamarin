using System;

using UIKit;

namespace ActivePassive
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			btnCalcular.TouchUpInside += delegate {
				try
				{
					double caja = double.Parse(txtCaja.Text);
					double banco = double.Parse(txtBanco.Text);
					double cuentasCobrar = double.Parse(txtCuentasPorCobrar.Text);
					double pagoCredito = double.Parse(txtPagoCredito.Text);
					double pagoProveedor = double.Parse(txtPagoProveedores.Text);
					double pagoRenta = double.Parse(txtPagoRenta.Text);

					double capitalContable = (caja + banco + cuentasCobrar)
						- (pagoCredito + pagoProveedor + pagoRenta);
					
					txtCapitalContable.Text = capitalContable.ToString();
				}
				catch (Exception e)
				{
					MessageBox("Error", (e.Message));
				}
			};
		}

		void MessageBox(string v, string message)
		{
			using (UIAlertView alerta = new UIAlertView())
			{
				alerta.Title = v;
				alerta.Message = message;
				alerta.AddButton("Ok");
				alerta.Show();
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
