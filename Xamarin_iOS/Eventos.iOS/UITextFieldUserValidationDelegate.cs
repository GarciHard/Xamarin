using System;
using UIKit;
using iOSEventsDemo.iOS;

namespace Eventos.iOS
{
	public class UITextFieldUserValidationDelegate : UITextFieldDelegate
	{
		public override bool ShouldChangeCharacters(UITextField textField, Foundation.NSRange range, string replacementString)
		{
			return Validations.ValidateInput(replacementString, Validations.ValidationType.User);
		}
	}
}
