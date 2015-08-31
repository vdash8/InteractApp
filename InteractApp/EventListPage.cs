using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace InteractApp
{
	public class EventListPage : ContentPage
	{
		public EventListPage ()
		{
			var EventList = new ListView {
				ItemsSource = new List<Event> () {
					new Event (0, "invalid_image_uri", "Event0", new DateTime(), "Fremont, CA", "Test Event 0", new List<String> (){ "service" })
				},
				RowHeight = 50,
			};

			// TODO: Make our own custom cell
			EventList.ItemTemplate = new DataTemplate (typeof(TextCell));
			EventList.ItemTemplate.SetBinding (TextCell.TextProperty, "Name");
			EventList.ItemTemplate.SetBinding (TextCell.DetailProperty, "Desc");

			EventList.ItemTapped += async (sender, e) => {
				await DisplayAlert("Tapped", ((Event) e.Item).Name + " row was tapped", "OK");
				Debug.WriteLine("Tapped: " + ((Event) e.Item).Name);
				((ListView)sender).SelectedItem = null; // de-select the row
			};

			Padding = new Thickness (0,20,0,0);
			Content = EventList;
		}
	}
}


