using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    //need to specify public otherwise it will default to "internal"
    {
        //constructor method
        public Book(string name){
            Name = name;
            grades = new List <double>();
        }
        public void AddGrade(double number){
            if (number <= 100 && number >= 0){
            grades.Add(number);
            }
            else Console.WriteLine("Invalid Value");
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            var index = 0;
            do
            {
            result.High = Math.Max(grades[index], result.High);
            result.Low = Math.Min(grades[index], result.Low);
            result.Average += grades[index];
            index++;
            } while(index < grades.Count);
            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}

//field - variable declaration in a class