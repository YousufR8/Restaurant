// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();

        // Add employees as shown below (you can add more employees if needed)
        restaurant.AddEmployee(new Employee(1, "John", "Doe", "Manager", 50000, DateTime.Parse("2022-01-15")));
        restaurant.AddEmployee(new Employee(2, "Jane", "Smith", "Waitstaff", 25000, DateTime.Parse("2022-02-20")));
        restaurant.AddEmployee(new Employee(3, "Bob", "Johnson", "Chef", 55000, DateTime.Parse("2022-03-10")));

        // Display all employees
        restaurant.DisplayAllEmployees();

        // Rest of the code for your application...

        // Add this line to keep the console window open until the user presses Enter
        Console.ReadLine();
    }
}