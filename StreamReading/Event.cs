using System;
namespace StreamReading
{
	public class Event
	{
		public string name { get; set; }
		public int cntparticipants { get; set; }
		public DateTime date { get; set; }
		public List<string> students { get; set; }

		public Event(string name, int cntparticipants, DateTime date, List<string> students)
		{
			this.name = name;
			this.cntparticipants = cntparticipants;
			this.date = date;
			this.students = students;

		}

    }
}

