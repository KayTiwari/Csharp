using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class Book
    //need to specify public otherwise it will default to "internal"
    {
        //constructor method
        public Book(string name){
            const int x = 3;
            Name = name;
            grades = new List <double>();
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter){
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }
        public void AddGrade(double number){
            if (number <= 100 && number >= 0){
            grades.Add(number);
            if (GradeAdded != null){
                GradeAdded(this, new EventArgs());
                //this keyword is the object being sent
            }
            }
            else Console.WriteLine("Invalid Value");
        }

        public event GradeAddedDelegate GradeAdded;

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

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;

            }

            return result;
        }

        private List<double> grades;

        public string Name {
            get; set;
            //read only
            //auto property
            //equivalent to setting public string Name;
        }

        public const string CATEGORY = "Science";
    }
}

//field - variable declaration in a class