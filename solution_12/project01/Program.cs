//namespace Project_Solution01
//{
//    internal class Program
//    {
//        class Animals
//        {
//            public void Sleep()
//            {
//                Console.WriteLine("Animal is sleeping");
//            }
//            public virtual void Sound()
//            {
//                Console.WriteLine("The animal makes a sound");
//            }
//            public virtual void Eat()
//            {
//                Console.WriteLine("Animal is eating");
//            }

//        }

//        class Dog : Animals
//        {
//            public override void Sound()
//            {
//                Console.WriteLine("Dog sounds Barking");
//            }

//            public override void Eat()
//            {
//                Console.WriteLine("Dog eats Meats");
//            }
//        }

//        static void Main(string[] args)
//        {
//            Dog dog = new Dog();

//            dog.Sound();
//            dog.Eat();

//            dog.Sleep();
//        }
//    }
//}


using System;

namespace Project_Solution01
{
    internal class Program
    {
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing Shape");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Circle");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Rectangle");
            }
        }

        static void Main(string[] args)
        {
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();

            s1.Draw();
            s2.Draw();
        }
    }
}


