using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var Maths = new MathLib();
            var a = 11;
            var b = 4;
            Console.WriteLine(Maths.Mod(a, b));
            var Added = Maths.Add(a, b);
            Console.WriteLine(Added);
            Added = Maths.Sub(a, b);
            Console.WriteLine(Added);
            Added = Maths.Mult(a, b);
            Console.WriteLine(Added);
            Added = Maths.Div(a, b);
            Console.WriteLine(Added);
            // Creates student, gave name property value, and ran print method
            var Matt = new Student();
            Matt.Name = "Matt";
            Matt.SAT = 1000;
            Matt.Print(5);

            // Same, but a second instance of the Student object
            var Elly = new Student();
            Elly.Name = "Elly";
            Elly.SAT = 2000;
            var EMessage = Elly.Print(1);
            Console.WriteLine(EMessage);

            // Third student
            var Barney = new Student();
            Barney.Name = "Barney";
            Barney.SAT = 1200;
            Barney.Print(3);
            Barney.SAT += 20;
            Barney.Print(2);
        }
    }   
}
