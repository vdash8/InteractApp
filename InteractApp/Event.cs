using System;
using System.Collections.Generic;

namespace InteractApp
{
	public class Event
	{
		public readonly int Id;
		public readonly String ImageUri;
		public readonly String Name;
		public readonly DateTime Date;
		public readonly String Location;
		public readonly String Desc;
		public readonly List<String> Tags;

		public Event(int EId, String EImageUri, String EName, DateTime EDate, String ELocation, String EDesc, List<String> ETags) {
			this.Id = EId;
			this.ImageUri = EImageUri;
			this.Name = EName;
			this.Date = EDate;
			this.Location = ELocation;
			this.Desc = EDesc;
			this.Tags = ETags;
		}
	}
}

