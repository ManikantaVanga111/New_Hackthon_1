using ClassLibrary1;

namespace ConsoleApp1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Resource sc = new Resource();
            //Console.WriteLine("Hello, World!");
            while (true)
            {
                Console.WriteLine("1 for Createdetails");
                Console.WriteLine("2 for VIewDetailsId");
                Console.WriteLine("3 for ViewallNotes");
                Console.WriteLine("4 for UpdateNotes");
                Console.WriteLine("5 for DeleteNote");
                try
                {

                    Console.WriteLine("Enter the choice");
                    int choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            {
                                sc.CreateDetails();
                                break;
                            }
                        case 2:
                            {
                                sc.ViewDetailsId();
                                break;
                            }
                        case 3:
                            {
                                sc.ViewAllNotes();
                                break;
                            }
                        case 4:
                            {
                                sc.UpdateNote();
                                break;
                            }
                        case 5:
                            {
                                if (sc.DeleteNote())
                                {
                                    Console.WriteLine("Successfully Deleted");
                                }
                                else
                                {
                                    Console.WriteLine("Id not found");
                                }
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Enter valid option");
                                break;

                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only Numbers From 1 to 5");
                }
            }


        }
    }
}