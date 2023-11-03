using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Square square = new Square();
        //    square.side = 2;
        //    Console.WriteLine(square.CalcularArea());
              TriangleOne triangleOne = new TriangleOne();
              triangleOne.Base = 4;
              triangleOne.Height = 9;
              Console.WriteLine(triangleOne.CalcularArea());
        }
    }
}