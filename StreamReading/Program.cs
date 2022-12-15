using System;
using System.IO;
using static System.Net.WebRequestMethods;
using File = System.IO.File;


namespace StreamReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath_event = @"/Users/elinagalimova/study/progrmmingTechnoligies/task.ten/StreamReading/bin/Debug/Events and cnt.txt";
            string filepath_perticipant = @"/Users/elinagalimova/study/progrmmingTechnoligies/task.ten/StreamReading/bin/Debug/Participant, group and cntevent.txt";


            List<Event> list_event = new List<Event>(); //event and cnt of participants

            using (StreamReader read = new StreamReader(filepath_event))
            {
                string line_event = read.ReadLine();

                while (line_event!=null)
                {
                    string[] i = line_event.Split();
                    int cnt;
                    if (int.TryParse(i[1], out cnt))
                    {
                        list_event.Add(new Event(i[0], cnt));
                    }
                    else
                    {
                        Console.WriteLine("Default!");
                    }
                   
                }

            }


          

        }
    }

}

