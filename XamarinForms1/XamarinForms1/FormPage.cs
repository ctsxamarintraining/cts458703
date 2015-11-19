using System;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using System.Diagnostics;


namespace XamarinForms1
{
	
	public class FormPage : ContentPage
	{

		SQLiteConnection database;
		public FormPage ()
		{
			RelativeLayout layout = new RelativeLayout {Padding=10};
			var label = new Label {
				Text = "Details Page",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),

			};

			layout.Children.Add (label,Constraint.Constant(120),Constraint.Constant(5));

			var CustomerNameLabel = new Label {
				Text = "Name"
			};
			layout.Children.Add(CustomerNameLabel,Constraint.Constant(40),Constraint.Constant(60));

			var username = new Entry {
				Placeholder = "Enter the Name"
			};
			layout.Children.Add(username,Constraint.Constant(135),Constraint.Constant(60));

			var Gender = new Label {
				Text = "Gender"
			};
			layout.Children.Add (Gender, Constraint.Constant (40), Constraint.Constant (120));

			Switch switcher = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			layout.Children.Add (switcher, Constraint.Constant (135), Constraint.Constant (120));

			var g = new Label {
				Text = "M"
			};
			layout.Children.Add (g, Constraint.Constant (210), Constraint.Constant (120));
			switcher.Toggled += (sender, e) => {
				if (switcher.IsToggled) {
					g.Text = "F";
				}
				else if(!(switcher.IsToggled)){
					g.Text = "M";
				}

			};
				

			var datePicker = new DatePicker ();
			layout.Children.Add (datePicker, Constraint.Constant (75), Constraint.Constant (170));


			var description = new Entry { Placeholder = "Description", IsPassword = false,BackgroundColor=Color.Gray,TextColor=Color.Red};
			layout.Children.Add(description,Constraint.Constant(75),Constraint.Constant(220),Constraint.Constant(250),Constraint.Constant(70));



			var picker = new Picker (){BackgroundColor=Color.Yellow,Title="Country"};
			picker.Items.Add ("India");
			picker.Items.Add ("China");
			picker.Items.Add ("USA");
			picker.Items.Add ("Japan");

			layout.Children.Add(picker, Constraint.Constant(140),Constraint.Constant(320),Constraint.Constant(100));

			var v = new BoxView {HeightRequest=1,BackgroundColor=Color.Blue
				
			};
			layout.Children.Add(v, Constraint.Constant(25),Constraint.Constant(348),Constraint.Constant(320));
		
			var button = new Button { Text = "Save the Data", TextColor = Color.Black,BackgroundColor=Color.Green};
			layout.Children.Add(button, Constraint.Constant(140),Constraint.Constant(360));


			button.Clicked += (sender, e) => {

				Person personObj=new Person(CustomerNameLabel.Text,g.Text,description.Text,datePicker.Date.ToString());
				database = DependencyService.Get<ISQLite> ().GetConnection ();


				try
				{
					database.CreateTable<Person>();
					database.Insert(personObj);	
				}
				catch (SQLiteException ex)
				{
					Debug.WriteLine(ex);
				}



			};



			this.Content = layout;


		}
	}
}


