using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
         static void Main(string[] args)
        {
            var book = new InMemoryBook("Gradebook");
            book.GradeAdded += onGradeAdded;
            
            while (true){
            Console.WriteLine("Enter a grade or press 'Q' to quit");
            var input = Console.ReadLine();
                if (input == "q"){
                    break;
                }
            var grade = double.Parse(input);
                book.AddGrade(grade);
            }

            var stats = book.GetStatistics();

            Console.WriteLine("\n",InMemoryBook.CATEGORY);
            Console.WriteLine($"Name is: {book.Name}");
            Console.WriteLine($"The Lowest Grade is {stats.Low}");
            Console.WriteLine($"The Highest Grade is {stats.High}");
            Console.WriteLine($"The Average Grade is {stats.Average:N1}");
            //N1 format for toFixed(1)
            Console.WriteLine($"The Letter Grade is {stats.Letter}");
            

            // book.grades.Add(52);

            // var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            // var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };

            // List<double> grades = new List<double>();
            //requires type argument ex: integers, strings, var, double floating points

            // grades.Add(56.1);
            //Add is a list method

            
            
        }
        //Method name is "Main"
        static void onGradeAdded(object sender, EventArgs e){
            Console.WriteLine("Grade was added!");
        }
    }
}

//Launch.json allowsyou to pass default arguments into debugger