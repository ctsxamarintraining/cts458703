// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Demo2
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btn { get; set; }

		[Outlet]
		UIKit.UITextField textField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btn != null) {
				btn.Dispose ();
				btn = null;
			}

			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}
		}
	}
}
