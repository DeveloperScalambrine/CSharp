using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle();
            bool result = triangle.isTriangle();
            bool resultEqui = triangle.Equilatero();
            bool resultIso = triangle.Isosceles();
            bool resultEsc = triangle.Escaleno();
            if (result == false)
            {
                Console.WriteLine("Não é triângulo");
            } else if (resultEqui == true)
                {             
                    Console.WriteLine("Equilátero");
                } else if (resultIso == true)
                  {
                    Console.WriteLine("Isosceles");
                  } else if (resultEsc == true)
                  {
                    Console.WriteLine("Escaleno");
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
   
            // Week dayWeek = new Week("sabado");
            // dayWeek.action();
            
            // CountList countList = new CountList();
            // countList.action();
            // countList.count();

            // AverageWithCondition.averageNote(AverageWithCondition.N1, AverageWithCondition.N2, AverageWithCondition.N3, AverageWithCondition.N4);
        }
    }
}
