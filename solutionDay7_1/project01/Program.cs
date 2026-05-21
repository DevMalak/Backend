namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void myCalculator()
            {
                bool again = true;

                while (again)
                {
                    Console.WriteLine("Please enter the first  number:");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the second number:");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose an operator (+, -, *, /):");
                    string operation = Console.ReadLine();

                    if (operation == "+")
                    {
                        Console.WriteLine("Output: " + (x + y));
                    }
                    else if (operation == "-")
                    {
                        Console.WriteLine("Output: " + (x - y));
                    }
                    else if (operation == "*")
                    {
                        Console.WriteLine("Output: " + (x * y));
                    }
                    else if (operation == "/")
                    {
                        if (y != 0)
                            Console.WriteLine("Output: " + (x / y));
                        else
                            Console.WriteLine("Error: Division by zero");
                    }
                    else
                    {
                        Console.WriteLine("Alert: Unknown operation");
                    }

                    Console.WriteLine("Perform another task? (yes/no)");
                    string answer = Console.ReadLine();

                    if (answer != "yes")
                    {
                        again = false;
                    }
                }

                Console.WriteLine("Program ended.");
            }

            myCalculator();
        }






    }
    }

