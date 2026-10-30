// //give me code of a c# program which includes
// // 5 movie, time, price in a seperate class
// // and customer details including name contact number date time movie as user input in another class 
// // the user has to choose a movie from the given 5 movies 

// // 1. FIXED: Added the missing semicolon at the end of the array
// Movie[] movies = new Movie[5]
// {
//     new Movie("Inception", "7:00 PM", 10.00),
//     new Movie("Avatar: The Way of Water", "8:30 PM", 12.00),
//     new Movie("The Dark Knight", "6:00 PM", 15.00),
//     new Movie("Spiderman: Brand New Day", "9:00 PM", 8.00),
//     new Movie("Avengers: Doomsday", "5:30 PM", 20.00)
// };

// Console.WriteLine("===============================================");
// Console.WriteLine("Welcome to the Movie Booking System");
// Console.WriteLine("===============================================");

// Console.WriteLine("Enter Customer name:");
// string name = Console.ReadLine() ?? "";

// Console.WriteLine("Enter Customer contact number:");
// string contactNumber = Console.ReadLine() ?? "";

// Console.WriteLine("Available Movies:");
// for (int i = 0; i < movies.Length; i++)
// {
//     // 2. FIXED: Combined into a single line for valid string interpolation
//     Console.WriteLine($"{i + 1}. {movies[i].Name} | {movies[i].Duration} | ${movies[i].Price}");
// }

// int choice = 0;
// while (choice < 1 || choice > movies.Length)
// {
//     Console.Write($"\nSelect a movie (1-{movies.Length}): ");
//     if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > movies.Length)
//     {
//         Console.WriteLine("Invalid choice. Please try again.");
//     }
// }

// Movie choosenMovie = movies[choice - 1];

// Console.Write("Enter Show date (MM/DD/YYYY): ");
// string date = Console.ReadLine() ?? "";

// Console.WriteLine("Enter Show time (HH:MM AM/PM): ");
// string time = Console.ReadLine() ?? "";

// // This now works because the Customer class has the matching constructor
// Customer customer = new Customer(name, contactNumber, date, time, choosenMovie);

// // --- Class Definitions ---

// class Movie
// {
//     public string Name;
//     public string Duration;
//     public double Price;

//     public Movie(string name, string duration, double price)
//     {
//         Name = name;
//         Duration = duration;
//         Price = price;
//     }
// }

// class Customer
// {
//     // 3. FIXED: Added properties and constructor to the Customer class
//     public string Name;
//     public string ContactNumber;
//     public string Date;
//     public string Time;
//     public Movie MovieBooked;

//     public Customer(string name, string contactNumber, string date, string time, Movie movieBooked)
//     {
//         Name = name;
//         ContactNumber = contactNumber;
//         Date = date;
//         Time = time;
//         MovieBooked = movieBooked;
//     }
// }

//encapsulation 

//    Student s = new Student();
//    s.SetAge(22);
//    Console.WriteLine(s.GetAge());
// class Student
// {
//     private int age;
//     public int GetAge()
//     {
//         return age;
//     }
//     public void SetAge(int newAge)
//     {
//         if(newAge >= 0 && newAge <= 120)
//         {
//             age = newAge;
//         }
//         else
//         {
//             Console.WriteLine("Invalid age. Please enter an age between 0 and 120.");
//         }
//     }
// }

// 1. Executable code must come first
    Person p = new Person();
    p.Name = "John";
    Console.WriteLine(p.Name); 

    // 2. Class definitions must come after
    class Person
    {
        private string name = "";
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }