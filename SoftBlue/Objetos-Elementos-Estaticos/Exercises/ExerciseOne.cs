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

// código para executar na main

//    Square square = new Square();
//    square.side = 2;
//    Console.WriteLine(square.CalcularArea());
//   TriangleOne triangleOne = new TriangleOne();
//   triangleOne.Base = 4;
//   triangleOne.Height = 9;
//   Console.WriteLine(triangleOne.CalcularArea());