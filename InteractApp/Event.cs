using System;
using System.Collections.Generic;

namespace InteractApp
{
	public class Event
	{
		public int Id { get; set; }
		public String ImageUri { get; set; }
		public String Name { get; set; }
		public DateTime Date { get; set; }
		public String Location { get; set; }
		public String Desc { get; set; }
		public List<String> Tags { get; set; }

		public static Event newEvent(int EId, String EImageUri, String EName, DateTime EDate, String ELocation, String EDesc, List<String> ETags)
		{
			Event e = new Event ();
			e.Id = EId;
			e.ImageUri = EImageUri;
			e.Name = EName;
			e.Date = EDate;
			e.Location = ELocation;
			e.Desc = EDesc;
			e.Tags = ETags;
			return e;
		}
	}
}

