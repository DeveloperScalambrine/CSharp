using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            bool result = triangle.isTriangle();
            bool resultEqui = triangle.equilatero();
            bool resultIso = triangle.isosceles();
            if (result == false)
            {
                System.Console.WriteLine("Não é triângulo");
            } else if (resultEqui == true)
                {             
                    System.Console.WriteLine("Equilátero");
                } else if (resultIso == true)
                  {
                    System.Console.WriteLine("Isosceles");
                  }
        
    
            
            
            // triangle.equilatero();
            // triangle.isosceles();
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
