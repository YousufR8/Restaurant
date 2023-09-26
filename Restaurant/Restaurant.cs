// Restaurant.cs

using System;
using System.Collections.Generic;

class Restaurant
{
    // Field
    private List<Employee> employees = new List<Employee>();

    // Method to add an employee
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    // Method to remove an employee based on their id
    public void RemoveEmployee(int id)
    {
        employees.RemoveAll(e => e.Id == id);
    }

    // Method to retrieve details of an employee based on their id
    public Employee GetEmployee(int id)
    {
        return employees.Find(e => e.Id == id);
    }

    // Method to display details of all employees
    public void DisplayAllEmployees()
    {
        Console.WriteLine("List of Employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.FullName()}, Role: {employee.Role}, Salary: {employee.Salary:C}, Date of Hire: {employee.DateOfHire:d}");
        }
    }
}
