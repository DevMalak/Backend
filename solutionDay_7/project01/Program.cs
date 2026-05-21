namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


    
                List<string> list01 = new List<string>();

                try
                {
                    list01.Add("Malak");
                    list01.Add("Ahmed");
                    list01.Add("Sara");

                    foreach (string s in list01)
                    {
                        Console.WriteLine(s);
                    }

                    Console.WriteLine("============================");

                    if (list01.Exists(x => x == "Malak"))
                    {
                        Console.WriteLine("Yes Element is here you can use find");
                    }

                    Console.WriteLine(list01.Find(x => x == "Malak"));

                    list01.Remove("Sara");

                    Console.WriteLine("Count is: " + list01.Count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }





        }
    }

