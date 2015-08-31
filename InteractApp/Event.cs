using System;
using System.Collections.Generic;

namespace InteractApp
{
	public class Event
	{
		int Id;
		String ImageUri;
		String Name;
		DateTime Date;
		String Location;
		String Desc;
		List<String> Tags;

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

