using System;
namespace StreamReading
{
	public class Event
	{
		public string name { get; set; }
		public int cntparticipants;

		public Event(string name, int cntparticipants)
		{
			this.name = name;
			this.cntparticipants = cntparticipants;
		}

    }
}

