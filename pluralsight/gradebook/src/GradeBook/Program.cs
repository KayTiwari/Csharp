using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };

            // List<double> grades = new List<double>();
            //requires type argument ex: integers, strings, var, double floating points

            grades.Add(56.1);
            //Add is a list method

            var result = 0.0;
            foreach(var number in grades){
                result += number;
            }
            var final = result/grades.Count;
            Console.WriteLine(final);
        }
        //Method name is "Main"
    }
}

//Launch.json allowsyou to pass default arguments into debugger