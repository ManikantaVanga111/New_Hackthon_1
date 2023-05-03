using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Resource
    {
      
            List<It> its = new List<It>();
            static int c = 1;
            public void CreateDetails()
            {

                Console.WriteLine("Enter the title");
                string title = Console.ReadLine();
                Console.WriteLine("Enter description");
                string description = Console.ReadLine();
            int count = c++;
                int id = count;
                 
                Console.WriteLine(id);
                DateTime date = DateTime.Now;
                Console.WriteLine(date);
                its.Add(new It() { Title = title, Description = description, Id = id, Date = date,Count=count });

            }
            public void ViewDetailsId()
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (It it in its)
                {
                    if (it.Id == id)
                    {
                        Console.WriteLine("id\ttitle\tdescription\tdate");
                        Console.WriteLine($"{it.Id}\t{it.Title}\t{it.Description}\t{it.Date}");

                    }
                }
            }
        public void ViewAllNotes()
        {
            foreach (It it in its)
            {
                Console.WriteLine("id\ttitle\tdescription\tdate");
                Console.WriteLine($"{it.Id}\t{it.Title}\t{it.Description}\t{it.Date}");

            }
            Console.WriteLine($"Total Notes {its.Count}");
        }

            public void UpdateNote()
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (It it in its)
                {
                    if (it.Id == id)
                    {
                        Console.WriteLine("Enter the update title");
                        it.Title = Console.ReadLine();
                        Console.WriteLine("Enter the update description");
                        it.Description = Console.ReadLine();
                    }
                }
            }
            public bool DeleteNote()
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (It it in its)
                {
                    if (it.Id == id)
                    {
                        its.Remove(it);
                        return true;
                    }
                }
                return false;
            }
        }
    }
