//namespace project_1
//{
//    internal class Program
//    {
//        class Car
//        {
//            public string color;
//            public int model_year;

//            private int temp;
//            public int Speed
//            {
//                get { return temp; }
//                set
//                {
//                    if (value > 0)
//                        temp = value;
//                }
//            }


//        }
//        static void Main(string[] args)
//        {
//            Car my_car = new Car();
//            Console.WriteLine("please Enter speed of car:");
//            my_car.Speed = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(my_car.Speed);
//        }
//    }
//}





#region constructor
namespace project_1
{
    internal class Program
    {
        class Car
        {
            public string Col;
            public int age;

            public Car(string color, int a)
            {
                Col = color;
                age = a;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a color");
            string color = Console.ReadLine();

            Console.WriteLine("Please Enter an age");
            int age = Convert.ToInt32(Console.ReadLine());

            Car myCar = new Car(color, age);

            Console.WriteLine(myCar.Col);
            Console.WriteLine(myCar.age);
        }
    }
}
#endregion