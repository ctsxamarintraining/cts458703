// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BinaryTreeFirstPage
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton generateNumbers { get; set; }

		[Outlet]
		UIKit.UIView mainView { get; set; }

		[Action ("generate:")]
		partial void generate (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (generateNumbers != null) {
				generateNumbers.Dispose ();
				generateNumbers = null;
			}

			if (mainView != null) {
				mainView.Dispose ();
				mainView = null;
			}
		}
	}
}
