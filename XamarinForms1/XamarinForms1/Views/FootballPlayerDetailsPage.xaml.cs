using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms1
{
	public partial class FootballPlayerDetailsPage : ContentPage
	{
		public FootballPlayerDetailsPage (object p)
		{
			InitializeComponent ();
			Person pObj = (Person)p;

			this.FirstNameDetail.Text = pObj.cName;
			this.DOBLabel.Text = pObj.date.ToString ();
			this.DescriptionDetail.Text = pObj.descriptiondet;
				
		}

	}
}

