using System;
namespace task.ten
{
	public class Person
	{
		//подписчик
		public string name { get; set; }
		public string interest { get; set; }

		public Person(string name, string interest)
		{
			this.name = name;
			this.interest = interest;
		}

		public void message(string entered)
		{

            if (entered == interest)
            {
                Console.WriteLine($"{name} likes the event {interest}!");
            }
            
		}
		
		
	}
}

