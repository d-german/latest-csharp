using System;

namespace LatestCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var point = new Point { X = 1.0, Y = 2.0 };
            Console.WriteLine(point);
            
            var point2 = point with { X = 3.0 };
            Console.WriteLine(point2);

            // Program.cs(15, 30): [CS9035] Required member 'Point.Y' must be set in the object initializer or attribute constructor.
            // var point3 = new Point { X = 1.0 };
        }
    }
}
