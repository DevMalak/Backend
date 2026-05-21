using System.Diagnostics;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region file create
            //string[] lines = { "malak", "rima", "salma" };

            //File.WriteAllLines("test01.txt", lines);

            //string myfile = File.ReadAllText("test01.txt");

            //Console.WriteLine("Hello, World!");
            //Console.WriteLine(myfile);

            //Console.WriteLine("+++++++++++++++++++++++");
            //Console.WriteLine("Hello from here , this is the C# course");

            //Console.WriteLine("Hello " + lines[0]);
            //Console.WriteLine("Hello " + lines[1]);
            //Console.WriteLine("Hello " + lines[2]);


            #endregion







            #region Task of Try and Catch

            //File.Create("Exam01.txt");
            //File.Create("Exam02.txt");
            //File.Create("Exam03.txt");


            Console.WriteLine("Enter number of exam you want");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (number == 1)
                {
                    Console.WriteLine("Opening: Exam01.txt");
                    Process.Start("notepad.exe", "Exam01.txt");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Opening: Exam02.txt");
                    Process.Start("notepad.exe", "Exam02.txt");
                }
                else if (number == 3)
                {
                    Console.WriteLine("Opening: Exam03.txt");
                    Process.Start("notepad.exe", "Exam03.txt");
                }
                else
                {
                    Console.WriteLine("The Value is Invalid");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion


        } 
    }
}


   