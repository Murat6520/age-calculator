using System;

using System.Globalization;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Age Calculator.");
        Console.WriteLine("\nEnter date: ");
        int date = Convert.ToInt32(Console.ReadLine());  // asking user for date
        Console.WriteLine("\nEnter Month of birth: ");
        int month = Convert.ToInt32(Console.ReadLine()); // asking user for month
        Console.WriteLine("\n Enter Year of Birth: ");
        int year = Convert.ToInt32(Console.ReadLine()); // asking user for year
        DateTime myDate = DateTime.Now; // finding current date time
        DateTime DOB = new DateTime(year, month, date); // Creating datetime object for user
        TimeSpan ts = myDate - DOB; // finding a time span between these two dates
        Console.WriteLine(Convert.ToInt32(ts.TotalDays / 365)); // finding total days and dividing by 365 to find total years

    }
}