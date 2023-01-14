using System;

namespace LatestCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var point = new Point { X = 1.0, Y = 2.0 };
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }
}
