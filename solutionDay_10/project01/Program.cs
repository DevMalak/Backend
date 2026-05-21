//using System;

//namespace project01
//{
//    internal class Program
//    {

//        static int Sum(int x, int y)
//        {
//            return x + y;
//        }

//        static double Sum(double x, double y)
//        {
//            return x + y;
//        }



//        //static int Sum(int x, int y)
//        //{
//        //    return x + y;
//        //}

//        //static int Sum(int x, int y, int z)
//        //{
//        //    return x * y * z;
//        //}

//        //static int Sum(int x, int y, int z, int w)
//        //{
//        //    return x + y + z + w;
//        //}

//        static void Main(string[] args)
//        {
//            //    Console.WriteLine(Sum(10, 20));
//            //    Console.WriteLine(Sum(10, 20, 30));
//            //    Console.WriteLine(Sum(10, 20, 30, 40));


//            Console.WriteLine(Sum(10, 20));
//            Console.WriteLine(Sum(10.5, 20.3));

//        }




//    }
//}






#region ref
//using System;

//namespace project01;

//internal class Program
//{
//    static void Increase(ref int x)
//    {
//        x = x + 1;
//    }

//    static void Main(string[] args)
//    {
//        int num = 5;

//        Increase(ref num);

//        Console.WriteLine(num);
//    }
//} 
#endregion





#region output
//using System;
//namespace project01;

//internal class Program
//{
//    static void Increase(out int x)
//    {
//        x = 1;
//    }

//    static void Main(string[] args)
//    {
//        int num;

//        Increase(out num);

//        Console.WriteLine(num);
//    }
//} 
#endregion







#region Recursion Function
//using System;

//namespace project01;

//internal class Program
//{
//    static void Hello()
//    {
//        Console.WriteLine("Please Enter Your Age");
//        int age = Convert.ToInt32(Console.ReadLine());

//        if (age < 18)
//            Hello();
//        else
//            return;
//    }

//    static void Main(string[] args)
//    {
//        Hello();
//    }
//} 
#endregion