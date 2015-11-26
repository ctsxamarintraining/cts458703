using System;

using UIKit;

namespace BinaryTreeFirstPage
{
	public partial class ViewController : UIViewController
	{
		UIView myView;
		UILabel label;
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{


			base.ViewDidLoad ();
			int xPosition = 65;
			int i = 0;

			int[] NumArray=new int[5];
			//int tagNum = 0;
			for (int k = 0; k < 5; k++) {
				myView = new UIView (new CoreGraphics.CGRect (xPosition, 30,51 , 51));
				label = new UILabel (new CoreGraphics.CGRect (24, 15, 42, 21));

				myView.Layer.CornerRadius = 25;

				myView.BackgroundColor = UIColor.Blue;
				//label.Text = "1";

				label.Tag = i;
				myView.Add (label);
				mainView.Add (myView);
				i=i++;

				xPosition = xPosition + 51;

			}
			//mainView.Hidden = true;
			generateNumbers.TouchUpInside += (sender, ea) => {
				
				for(int j=0;j<4;j++)
				{
					NumArray[j]= RandomNumber(1,100);

				}

				for(int h=0;h<NumArray.Length;h++)
				{
					if(label.Tag==0)
					{
						label.Text=NumArray[h].ToString();

					}



				}



			};

			// Perform any additional setup after loading the view, typically from a nib.
		}
		public int RandomNumber(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

