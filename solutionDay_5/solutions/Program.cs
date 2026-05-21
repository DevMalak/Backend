namespace solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region mulidimentional arry
            //Console.WriteLine("Enter number of rows:");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter number of columns:");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //int[,] x = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"[{i},{j}] = ");
            //        x[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n******************************");
            //Console.WriteLine("Array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.WriteLine($"[{i},{j}] = {x[i, j]}");
            //    }
            //} 
            #endregion




            #region Jagged Array
            //    int[,] numbers = new int[3, 3];
            //    int[][] numbers02 = new int[3][];

            //    numbers02[0] = new int[3];
            //    numbers02[1] = new int[2];
            //    numbers02[2] = new int[4];

            //    numbers02[0][0] = 10;
            //    numbers02[0][1] = 20;
            //    numbers02[0][2] = 30;

            //    numbers02[1][0] = 40;
            //    numbers02[1][1] = 50;

            //    numbers02[2][0] = 60;
            //    numbers02[2][1] = 70;
            //    numbers02[2][2] = 80;
            //    numbers02[2][3] = 90;

            //    int[][] numbers03 =
            //    {
            //    new int[]{10, 20, 30},
            //    new int[]{40, 50},
            //    new int[]{60, 70, 80, 90}
            //};

            //    Console.WriteLine(numbers03[0][2]);

            #endregion



            #region Part 1 – Student Names (One Dimensional Array)


            string[] students = new string[5];
            Console.WriteLine("Enter 5 student names:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("\nStudent List:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i}: {students[i]}");
            }
            #endregion



            #region Part 2 – Student Grades (Multi-Dimensional Array)
            int[,] grades = new int[5, 3];

            string[] subjects = { "Math", "Science", "English" };

            Console.WriteLine("\nEnter grades for each student:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n{students[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter {subjects[j]} grade: ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            #endregion




            #region Part 3 – Display Student Grades
            Console.WriteLine("\n--- Grades Table ---");

            Console.WriteLine("Name\tMath\tScience\tEnglish");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{students[i]}\t");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grades[i, j] + "\t");
                }

                Console.WriteLine();
            }

            #endregion



            #region Part 4 – Calculate Student Average


            Console.WriteLine("\n--- Student Averages ---");

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = sum / 3.0;

                Console.WriteLine($"{students[i]} Average = {avg}");
            }

            #endregion




            #region Part 5 – Jagged Array

            int[][] studentGrades = new int[5][];
            studentGrades[0] = new int[] { 80, 90, 70 };
            studentGrades[1] = new int[] { 60, 75 };
            studentGrades[2] = new int[] { 88, 92, 85, 90 };
            studentGrades[3] = new int[] { 50, 65, 70 };
            studentGrades[4] = new int[] { 100 };


            Console.WriteLine("\n---  Array ---");

            for (int i = 0; i < studentGrades.Length; i++)
            {
                Console.WriteLine($"\n{students[i]}:");

                Console.WriteLine("Number of subjects: " + studentGrades[i].Length);

                Console.Write("Grades: ");

                for (int j = 0; j < studentGrades[i].Length; j++)
                {
                    Console.Write(studentGrades[i][j] + " ");
                }

                Console.WriteLine();
            }
            #endregion




            #region Part 6 – Search for Student
            Console.Write("\nEnter student name to search: ");
            string searchName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == searchName)
                {
                    Console.WriteLine($"Student found at index: {i}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found");
            }


            #endregion




            #region Part 7 – Find Highest Grade
            int highest = grades[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grades[i, j] > highest)
                    {
                        highest = grades[i, j];
                    }
                }
            }

            Console.WriteLine("Highest Grade = " + highest);
            #endregion






            #region 1. Sort students alphabetically.

            Array.Sort(students);

            Console.WriteLine("\n--- Sorted Students ---");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            #endregion




            #region 2. Find the student with the highest average.
            double highestAvg = 0;
            int index = 0;

            for (int i = 0; i < students.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = sum / 3.0;

                if (avg > highestAvg)
                {
                    highestAvg = avg;
                    index = i;
                }
            }

            Console.WriteLine("\n--- Highest Average Student ---");
            Console.WriteLine(students[index] + " = " + highestAvg);


            #endregion






            #region 3. Count how many students passed (grade >= 50).
            int passedCount = 0;

            for (int i = 0; i < students.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = sum / 3.0;

                if (avg >= 50)
                {
                    passedCount++;
                }
            }

            Console.WriteLine("\n--- Students Passed ---");
            Console.WriteLine("Passed Students = " + passedCount);


            #endregion














        }
    }
}
