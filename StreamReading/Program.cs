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
            string filepath_event = "/Users/elinagalimova/study/progrmmingTechnoligies/task.ten/StreamReading/bin/Debug/Events and cnt.txt";
            string filepath_perticipant = "/Users/elinagalimova/study/progrmmingTechnoligies/task.ten/StreamReading/bin/Debug/student, group and cntevent.txt";
            //string filepath_preferences = @"/Users/elinagalimova/study/progrmmingTechnoligies/task.ten/StreamReading/bin/Debug/preferences.docx";

            string filepath_clearfile = "/Users/elinagalimova/study/progrmmingTechnoligies/task.ten/StreamReading/bin/Debug/дозапись.txt";

            //Dictionary<string, int> dict_event = new Dictionary<string, int>();
            ////key = event.name
            ////value = event.cntparticipants
            //using (StreamReader read = new StreamReader(filepath_event))
            //{
            //    string line_event = read.ReadLine();

            //    while(line_event!=null)
            //    {
            //        string[] i = line_event.Split();
            //        int cnt;
            //        if (int.TryParse(i[1], out cnt))
            //        {
            //            dict_event[i[0]] = cnt;
            //        }
            //    }
            //}

            //Dictionary<string, int[]> dict_participants = new Dictionary<string, int[]>();
            ////key = part.name
            ////value = part.group and part.cntevent
            //using (StreamReader read = new StreamReader(filepath_perticipant))
            //{
            //    string line_part = read.ReadLine();

            //    while(line_part!=null)
            //    {
            //        string[] i = line_part.Split();
            //        int gr;
            //        int ev;
            //        if ((int.TryParse(i[1], out gr)) && (int.TryParse(i[2], out ev)))
            //        {
            //            int[] q = { gr, ev };
            //            dict_participants[i[0]] = q;
            //        }
            //    }
            //}

            //Dictionary<string, string> dict_preferences = new Dictionary<string, string>();
            ////key = pref.namestud
            ////value = pref
            //using (StreamReader read = new StreamReader(filepath_preferences))
            //{
            //    string line_pref = read.ReadLine();

            //    while(line_pref!=null)
            //    {
            //        string[] i = line_pref.Split();
            //        dict_preferences[i[0]] = i[1];
            //    }
            //}

            //using (StreamWriter writer = new StreamWriter(filepath_clearfile, true))
            //{
            //    string start = "Участники хакатона (их должно быть 3): ";
            //    writer.Write(start);

            //    string i = ;
            //    string j = "Хакатон";
            //    if (dict_preferences[i] == )


            //}

            List<Event> events = new List<Event>();
            using (StreamReader read = new StreamReader(filepath_event))
            {
                //name cnt date list_stud
                string str = read.ReadLine();

                while (str!=null)
                {
                    string[] i = str.Split();
                    int cnt;
                    if (int.TryParse(i[1], out cnt))
                    {
                        events.Add(new Event(i[0], cnt, new DateTime(), new List<string>()));
                    }
                }
            }

           

            List<Participant> pertin = new List<Participant>();
            using (StreamReader read = new StreamReader(filepath_perticipant))
            {
                //name, gr cnt, pref
                string str = read.ReadLine();

                while (str != null)
                {
                    string[] i = str.Split();
                    int gr;
                    int evcnt;
                    if (int.TryParse(i[1], out gr) && int.TryParse(i[2], out evcnt))
                    {
                        pertin.Add(new Participant(i[0], gr, evcnt, i[3]));
                       
                    }
                }
            }



            





            using (StreamWriter writer = new StreamWriter(filepath_clearfile, true))
            {
                foreach (var i in events)
                {
                    foreach (var j in pertin)
                    {
                        if (i.name == j.preferences && i.name == "Хакатон")
                        {
                            writer.Write(i.name, j.group, j.name, i.date);
                            writer.WriteLine();
                        }
                        else if (i.name == j.preferences && i.name == "Танец")
                        {
                            writer.Write(i.name, j.group, j.name, i.date);
                            writer.WriteLine();
                        }
                        else if (i.name == j.preferences && i.name == "Старты")
                        {
                            writer.Write(i.name, j.group, j.name, i.date);
                            writer.WriteLine();
                        }
                        else if (i.name == j.preferences && i.name == "МИМ")
                        {
                            writer.Write(i.name, j.group, j.name, i.date);
                            writer.WriteLine();
                        }
                        else if (i.name == j.preferences && i.name == "Нет")
                        {
                            writer.Write(i.name, j.group, j.name, i.date);
                            writer.WriteLine();
                        }
                    }

                }
            }



        }
    }

}

