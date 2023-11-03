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
}