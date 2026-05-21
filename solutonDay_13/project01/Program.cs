namespace Project_Solution01
{
    #region Association 
    //internal class Program
    //{

    //    class Teacher
    //    {
    //        public string Name;

    //        public Teacher(string name)
    //        {
    //            Name = name;
    //        }
    //    }

    //    class Student
    //    {
    //        public string Name;

    //        public Student(string name)
    //        {
    //            Name = name;
    //        }

    //        public void StudyWith(Teacher t)
    //        {
    //            Console.WriteLine($"{Name} studies with teacher {t.Name}");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Teacher teacher = new Teacher("Mona");
    //        Student student = new Student("Salim");

    //        student.StudyWith(teacher);
    //    }
    //}
    #endregion

    //********************************************************
    #region Aggregation 
    //class Student
    //{
    //    public string Name;

    //    public Student(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //class University
    //{
    //    public string Name;

    //    public List<Student> Students;

    //    public University(string name)
    //    {
    //        Name = name;
    //        Students = new List<Student>();
    //    }

    //    public void AddStudent(Student s)
    //    {
    //        Students.Add(s);
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Student s1 = new Student("malak");
    //        Student s2 = new Student("noura");

    //        University u = new University("Nizwa University");

    //        u.AddStudent(s1);
    //        u.AddStudent(s2);

    //        Console.WriteLine("University: " + u.Name);

    //        foreach (var x in u.Students)
    //        {
    //            Console.WriteLine("Student: " + x.Name);
    //        }

    //    }
    //}
    #endregion

    //*****************************************************************
    #region Composition 
    class Room
    {
        public string Name;

        public Room(string name)
        {
            Name = name;
        }
    }

    class House
    {
        private List<Room> rooms;

        public House()
        {
            rooms = new List<Room>();

            rooms.Add(new Room("DedRoom"));
            rooms.Add(new Room("Kitchen"));
            rooms.Add(new Room("Living Room"));
        }

        public void ShowRooms()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.Name);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            House h = new House();

            h.ShowRooms();
        }
    }
    #endregion

    //********************************************************
}