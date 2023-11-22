using System;

namespace CSharp
{
  //  public class TriangleOneException  : SystemException
  // {
  // public TriangleOneException() { }
  // public TriangleOneException(string message) : base(message) { }
  // public TriangleOneException(string message, System.Exception inner) : base(message, inner) { }
  // }
    public class TriangleOne
    {
      public static string Nome { get; set; }
      public TriangleOne(string name)
      {
        Nome = name;
      }
      public override string ToString()
      {
        return $" Seja bem vindo: {Nome}";
      }
    }
    public static class TriangleTwo {
      public static void ExtensionMethod(this TriangleOne one)
    {
      Console.WriteLine(one.ToString(), "hello extension");
    }
  }
}
//     private static int numPaginas;
//     public int GetNumPaginas(){return numPaginas;}
//     public static void SetNumPaginas(int numPaginas) {
//       if (numPaginas <= 0 )
//       {
//         throw new TriangleOneException("Numero não pode ser menor que zero");
//       }
//         TriangleOne.numPaginas = numPaginas;
//         Console.WriteLine(TriangleOne.numPaginas);        
//     }

//     public static double Base { get; set; }
//     public static double Height { get; set; }
//     public TriangleOne()
//     {
//       Console.WriteLine("Type base ");
//       double bases  = Convert.ToDouble(Console.ReadLine());
//       Console.WriteLine("Type height ");
//       double height = Convert.ToDouble(Console.ReadLine());
//       Base = bases;
//       Height = height;
//       Console.WriteLine("construtor 1");
//     }
//     public TriangleOne(double bases, double height) {
//       Console.WriteLine("Type base ");
//       bases = Convert.ToDouble(Console.ReadLine());
//       Console.WriteLine("Type height ");
//       height = Convert.ToDouble(Console.ReadLine());
//       Base = bases;
//       Height = height;
//       Console.WriteLine("construtor 2");
//     }
//     public double CalcularArea() {
//       const int Div = 2;
//       return Base * Height / Div;
//     } 
//   }
// }
// public class Square {
//     public double side;

//     public double CalcularArea() {
//       return side * side;
//     }
//   }

//   public class Circumference {
//     public double n = Math.PI;
//     public int ray; 
//     public double CalcularArea() {
//       Console.WriteLine("Type value of ray: ");
//       ray = Convert.ToInt32(Console.ReadLine());
//       return 2 * n * ray;
//     }
//   }  
//   public class Trapeze
//   {
//     public double bigestBase = 20;
//     public double smallerBase = 7;
//     public int height = 14;

//     public double CalcularArea() {
//       double a = (bigestBase + smallerBase) * height / 2;
//       return a;
//      }

