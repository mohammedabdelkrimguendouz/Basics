using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Example
{
    internal class Program
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static Point operator +(Point P1, Point P2)
            {
                int X = P1.X + P2.X;
                int Y = P1.Y + P2.Y;
                return new Point(X, Y);
            }
            public static Point operator -(Point P1, Point P2)
            {
                int X = P1.X - P2.X;
                int Y = P1.Y - P2.Y;
                return new Point(X, Y);

            }
            public static bool operator ==(Point P1, Point P2)
            {
                
                return (P1.X==P2.X) && (P1.Y==P2.Y);

            }
            public static bool operator !=(Point P1, Point P2)
            {
                return !(P1==P2);
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }

        }
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(3, 4);

            // Using the overloaded + operator for point addition
            Point point3 = point1 + point2;

            // Using the overloaded + operator for point addition
            Point point4 = point1 - point2;

            Console.WriteLine($"Point1 : {point1.ToString()}");
            Console.WriteLine($"Point2 : {point2.ToString()}");
            Console.WriteLine($"Point3 is the result of point1 + point2: {point3.ToString()}");
            Console.WriteLine($"Point4 is the result of point1 - point2: {point4.ToString()}");

            // Using the overloaded == operator for point equality
            if (point1 == point2)
                Console.WriteLine("Using == : Yes, Point1 = Point2");
            else
                Console.WriteLine("Using == : No, Piont1 does not equal Point2");

            // Using the overloaded != operator for point inequality
            if (point1 != point2)
                Console.WriteLine("Using != : Yes, Piont1 does not equal Point2");
            else
                Console.WriteLine("Using != : No, Piont1 = Point2");

            Console.ReadKey();
        }
    }
}
