using System;
namespace StreamReading
{
	public class Participant
	{
		public string name { get; set; }
		public int group { get; set; }
		public int cntevent { get; set; }
		public string preferences { get; set; }
		
		public Participant(string name, int group, int cntevent, string preferences)
		{
			this.name = name;
			this.group = group;
			this.cntevent = cntevent;
			this.preferences = preferences;
			
		}
    }
}

