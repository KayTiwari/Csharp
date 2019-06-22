using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            Console.WriteLine($"Hello {args[0]}");
        }
        //Method name is "Main"
    }
}

//Launch.json allowsyou to pass default arguments into debugger