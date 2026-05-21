using System;

namespace Project_Solution01
{
    
    #region Movie class to store movie information
    class Movie
    {
        private string title;
        private string genre;
        private int year;
        private int rating;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                if (value >= 1 && value <= 10)
                    rating = value;
                else
                    rating = 5;
            }
        }

        public Movie(string title, string genre, int year, int rating = 5)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Rating = rating;
        }
    }
    #endregion

    #region user class
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"Welcome {Name}!");
        }
    }

    #endregion


    #region Review class
    class Review
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }

        public Review(string userName, string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Movies
            Movie m1 = new Movie("The Last Signal", "Sci-Fi", 2020, 9);
            Movie m2 = new Movie("Hidden Truth", "Drama", 2018, 8);
            Movie m3 = new Movie("Sky Hunters", "Action", 2022, 7); 
            #endregion

            
            User u1 = new User("Malak", 25);

          

            #region Display movies  


            Console.WriteLine("\nMovies:");
            Console.WriteLine($"{m1.Title} - {m1.Rating}");
            Console.WriteLine($"{m2.Title} - {m2.Rating}");
            Console.WriteLine($"{m3.Title} - {m3.Rating}");


            #endregion


            #region Review
            Review r1 = new Review("Malak", "The Last Signal", "Amazing story!", 10);

            #endregion


            #region Display reviews

            Console.WriteLine("\nReviews:");
            Console.WriteLine($"{r1.UserName} rated {r1.MovieTitle}: {r1.Rate} - {r1.Comment}"); 
            #endregion
        }
    }
}