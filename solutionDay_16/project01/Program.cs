using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> stds = new List<Student>()
        {
            new Student { Name = "ahmed", Age = 27 },
            new Student { Name = "mohmmed", Age = 27 },
            new Student { Name = "fatahia", Age = 50 },
            new Student { Name = "malak", Age = 90 },
            new Student { Name = "noor", Age = 100 }
        };

        //******************************************************///
        //        /////Query Syntax:///////
        var resulto =
            from s in stds
            where s.Age > 75
            select s;
        foreach (var s in stds)
        {
            if (s.Age > 75)
                Console.WriteLine(s.Name);
        }
        ////******************************************************///
        //Method Syntax//
        var result = stds.Where(x => x.Age > 75);
        foreach (var s in result)
        { Console.WriteLine(s.Name); }
        //******************************************************///

        //////************ LINQ *****************///
        //-------------1-Where --------------------/
        var result0 = stds.Where(hamada => hamada.Age > 75);
        var result2 = stds.Where(x => x.Age > 50).Select(x => x.Name);

        //-------------------2-elect-------------------/
        var result1 = stds.Select(x => x.Name);

        //-------------------3-OrderBy --------------------/
        var result3 = stds.OrderBy(x => x.Name);

        //-------------------4-OrderByDescending-------------------/
        var result4 = stds.OrderByDescending(x => x.Age);

        //-------------------5-FirstOrDefault----------------------/
        var student = stds.FirstOrDefault(x => x.Age == 1);

        //----------------------6-Count-------------------------/
        int total = stds.Count(); 
        int total1 = stds.Count(x => x.Age > 50); 

        //-------------------7-Any----------------------------/
        bool found = stds.Any(x => x.Age > 60);

    }
}