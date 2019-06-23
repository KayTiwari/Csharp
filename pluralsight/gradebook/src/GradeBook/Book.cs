using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    //need to specify public otherwise it will default to "internal"
    {
        //constructor method
        public Book(string name){
            this.name = name;
            grades = new List <double>();
        }
        public void AddGrade(double number){
            grades.Add(number);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(double number in grades){
            result.High = Math.Max(number, result.High);
            result.Low = Math.Min(number, result.Low);
            result.Average += number;
            }
            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        private string name;
    }
}

//field - variable declaration in a class