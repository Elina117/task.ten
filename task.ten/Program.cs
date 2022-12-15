using System;

namespace task.ten
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //create the list of persons
            List<Person> students = new List<Person>
            {
                new Person("Elina", "concert"),
                new Person("Nastya", "cinema"),
                new Person("Rustam", "serials")
            };

            Console.Write("Enter the name of the event ");
            string entered_event = Console.ReadLine();

            Compare compare = new Compare();
            foreach (var i in students)
            {
                compare.React += i.message;

            }

            compare.compare(entered_event);
            
        }
    }
}

