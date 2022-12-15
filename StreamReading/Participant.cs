using System;
namespace StreamReading
{
	public class Participant
	{
		public string name { get; set; }
		public int group { get; set; }
		public int cntevent { get; set; }

		public Participant(string name, int group, int cntevent)
		{
			this.name = name;
			this.group = group;
			this.cntevent = cntevent;
		}
    }
}

