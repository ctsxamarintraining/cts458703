using System;
using Xamarin.Forms.Platform.iOS;
using XamarinForms1;
using UIKit;



[assembly: Xamarin.Forms.Dependency (typeof(ImagePickerControllerPage))]
namespace XamarinForms1.iOS
{



	public class ImagePicker:PageRenderer
	{
		public ImagePicker ()
		{
			UIImagePickerController controller = new UIImagePickerController ();
			controller.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;

		}
	}
}

