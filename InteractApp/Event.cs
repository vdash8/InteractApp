using System;
using System.Collections.Generic;

namespace InteractApp
{
	public class Event
	{
		public int Id;
		public String ImageUri;
		public String Name;
		public DateTime Date;
		public String Location;
		public String Desc;
		public List<String> Tags;

		public Event (int EId, String EImageUri, String EName, DateTime EDate, String ELocation, String EDesc, List<String> ETags)
		{
			Id = EId;
			ImageUri = EImageUri;
			Name = EName;
			Date = EDate;
			Location = ELocation;
			Desc = EDesc;
			Tags = ETags;
		}
	}
}

