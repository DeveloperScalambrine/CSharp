using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            bool result = triangle.isTriangle();
            if (result == false)
            {
                System.Console.WriteLine("Não é triângulo");
                
            }
            
            // triangle.isTriangle();
            triangle.equilatero();
            triangle.isosceles();
            // triangle.escaleno();
            // Week dayWeek = new Week("sabado");
            // dayWeek.action();
            
            // CountList countList = new CountList();
            // countList.action();
            // countList.count();

            // AverageWithCondition.averageNote(AverageWithCondition.N1, AverageWithCondition.N2, AverageWithCondition.N3, AverageWithCondition.N4);
        }
    }
}
