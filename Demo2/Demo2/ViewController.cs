using System;
using Foundation;

using UIKit;

namespace Demo2
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			btn.TouchUpInside+=(sender, ea) => {
				new UIAlertView("Touch2", "TouchUpInside handled", null, "OK", null).Show();
				this.PerformSegue("loginSegue", this);
				//SecondViewController sec=(SecondViewController)Storyboard.InstantiateViewController("loginScreen");
				//sec.ModalTransitionStyle=UIModalTransitionStyle.PartialCurl;



			};

			// Perform any additional setup after loading the view, typically from a nib.
		}




		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			if (segue.Identifier == "loginSegue") {
				SecondViewController itvc = (SecondViewController)segue.DestinationViewController;
				itvc.ModalTransitionStyle = UIModalTransitionStyle.CoverVertical;

				itvc.recieveData (textField.Text);


			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

