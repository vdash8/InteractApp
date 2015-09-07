using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InteractApp
{
	public partial class EventInfoPage : ContentPage
	{
		public EventInfoPage ()
		{
			InitializeComponent ();

			Event e = Event.newEvent(0, "back.png", "Event2", new DateTime(), "Fremont, CA", "Test Event 0", new List<String> (){ "service" });

			evtName.Text = "Event Name 1";
			//var btnImage = new Image { Aspect = Aspect.AspectFit };
			//btnImage.Source = ImageSource.FromFile("back.png?");
			//backBtn.Image = (FileImageSource)btnImage.Source;
			backBtn.Image = (FileImageSource) ImageSource.FromFile("back.png");

			evtPic.Source= (FileImageSource) ImageSource.FromFile("lilies.jpg");
			evtDate.Text = DateTime.Now.ToString ("G");
			evtLoc.Text = "Irvington High School";
			evtDescLabel.Text = "Event Description";

			evtDesc.Text = "Now Is the time for all good men to come to the aid of their people.This is an event description. " +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah." +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah." +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah." +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah." +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah." +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah." +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah." +
				"Blah blah blah.Now Is the time for all good men to come to the aid of their people.This is an event description. Blah blah blah.";
			evtTags.Text = "Tags";
			LoadEvent (e);
		}

		public void LoadEvent(Event evt) 
		{
			evtName.Text = evt.Name;
			backBtn.Image = (FileImageSource)ImageSource.FromFile (evt.ImageUri);

		}
		public void onClicked() {
		}


	}
}

