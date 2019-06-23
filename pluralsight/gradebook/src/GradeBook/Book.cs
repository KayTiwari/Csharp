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
        private List<double> grades;
        private string name;
    }
}

//field - variable declaration in a class