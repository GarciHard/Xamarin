// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ActivePassive
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnCalcular { get; set; }

		[Outlet]
		UIKit.UITextField txtBanco { get; set; }

		[Outlet]
		UIKit.UITextField txtCaja { get; set; }

		[Outlet]
		UIKit.UITextField txtCapitalContable { get; set; }

		[Outlet]
		UIKit.UITextField txtCuentasPorCobrar { get; set; }

		[Outlet]
		UIKit.UITextField txtPagoCredito { get; set; }

		[Outlet]
		UIKit.UITextField txtPagoProveedores { get; set; }

		[Outlet]
		UIKit.UITextField txtPagoRenta { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtCaja != null) {
				txtCaja.Dispose ();
				txtCaja = null;
			}

			if (txtBanco != null) {
				txtBanco.Dispose ();
				txtBanco = null;
			}

			if (txtCuentasPorCobrar != null) {
				txtCuentasPorCobrar.Dispose ();
				txtCuentasPorCobrar = null;
			}

			if (txtPagoCredito != null) {
				txtPagoCredito.Dispose ();
				txtPagoCredito = null;
			}

			if (txtPagoProveedores != null) {
				txtPagoProveedores.Dispose ();
				txtPagoProveedores = null;
			}

			if (txtPagoRenta != null) {
				txtPagoRenta.Dispose ();
				txtPagoRenta = null;
			}

			if (txtCapitalContable != null) {
				txtCapitalContable.Dispose ();
				txtCapitalContable = null;
			}

			if (btnCalcular != null) {
				btnCalcular.Dispose ();
				btnCalcular = null;
			}
		}
	}
}
