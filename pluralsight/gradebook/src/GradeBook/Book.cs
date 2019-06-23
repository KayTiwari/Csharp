using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        //constructor method
        public Book(string name){
            this.name = name;
            grades = new List <double>();
        }
        public void AddGrade(double number){
            grades.Add(number);
        }

        internal void ShowStatistics()
        {
            double result = 0;
            var highgrade = double.MinValue;
            var lowgrade = double.MaxValue;
            foreach(double number in grades){
            highgrade = Math.Max(number, highgrade);
            lowgrade = Math.Min(number, lowgrade);
            result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"Average: {result}");
            Console.WriteLine($"Highest grade: {highgrade}");
            Console.WriteLine($"Lowest grade: {lowgrade}");
        }

        private List<double> grades;
        private string name;
    }
}

//field - variable declaration in a class