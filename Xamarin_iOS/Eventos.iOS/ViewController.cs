using System;

using UIKit;
using iOSEventsDemo.iOS;
using Foundation;

namespace Eventos.iOS
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
			btnLogin.AccessibilityIdentifier = "myButton";
			btnLogin.TouchUpInside += BtnLogin_TouchUpInside;
			txtUsername.Delegate = new UITextFieldUserValidationDelegate();
			txtPassword.WeakDelegate = this;

		}

		partial void ValueChanged(UITextField sender)
		{
			if (!string.IsNullOrEmpty(txtUsername.Text))
				txtPassword.Enabled = true;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		void BtnLogin_TouchUpInside(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
			{
				txtCode.Enabled = true;
				btnLogin.TouchUpInside -= BtnLogin_TouchUpInside;
				btnLogin.TouchUpInside += (send, evt) => this.ShowPopup("Hello", "¡Alert!");
			}
		}

		[Export("textField:shouldChangeCharactersInRange:replacementString")]
		public bool ShouldChangeCharacters(UITextField textField, Foundation.NSRange range, string replacementString)
		{
			return Validations.ValidateInput(replacementString, Validations.ValidationType.Password);
		}

	}
}
