using System;

namespace CSharp
{
  public class TriangleOne {
    public double Base;
    public double Height;

    public double CalcularArea() {
      const int Div = 2;
      return Base * Height / Div;
    } 
  }

  public class Square {
    public double side;

    public double CalcularArea() {
      return side * side;
    }
  }

  public class Circumference {
    public double n = Math.PI;
    public int ray; 
    public double CalcularArea() {
      Console.WriteLine("Type value of ray: ");
      ray = Convert.ToInt32(Console.ReadLine());
      return 2 * n * ray;
    }
  }  
  public class Trapeze
  {
    public double bigestBase = 20;
    public double smallerBase = 7;
    public int height = 14;

    public double CalcularArea() {
      double a = (bigestBase + smallerBase) * height / 2;
      return a;
     }
  }
}