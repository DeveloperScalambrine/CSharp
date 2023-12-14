using System;

namespace CSharp
{
    public class Triangle
    {
        public int SideA = 23;
        public int SideB = 12;
        public int SideC = 12;
        bool message = true;
        
        public bool isTriangle()
        {
             
            if (!(SideA < SideB + SideC) || (SideB < SideA + SideC) || (SideC < SideA + SideB)) 
            {
                message = false;
            }           
                return message;
        }

        public bool Equilatero(){
            if ((SideA == SideB) && (SideB == SideC))
            {
                message = true;
            
            } else { message = false;}
            
            return message;
        }

        public bool Isosceles(){
            if ((SideA == SideB) || (SideA == SideC) || (SideB == SideC)) 
            {
                message = true;
            } else { message = false;}

            return message;
        }
        
        public bool Escaleno(){
            if ((SideA != SideB) && (SideB != SideC) && (SideA != SideC)) 
            {
                message = true;
            
            } else { message = false;}
            
            return message;
        }     
    }
}

/*
Código para executar na main

// Triangle triangle = new Triangle();
            // bool result = triangle.isTriangle();
            // bool resultEqui = triangle.Equilatero();
            // bool resultIso = triangle.Isosceles();
            // bool resultEsc = triangle.Escaleno();
            // if (result == false)
            // {
            //     Console.WriteLine("Não é triângulo");
            // } else if (resultEqui == true)
            //     {             
            //         Console.WriteLine("Equilátero");
            //     } else if (resultIso == true)
            //       {
            //         Console.WriteLine("Isosceles");
            //       } else if (resultEsc == true)
            //       {
            //         Console.WriteLine("Escaleno");
            //       }
                    
            
            // triangle.equilatero();
            // triangle.isosceles();
            // triangle.escaleno();
            
*/

// TriangleOne triangleOne = new TriangleOne("jose");
// // TriangleOne carlos = new TriangleOne("Carlos");
// TriangleTwo.ExtensionMethod(triangleOne);

// Console.WriteLine(carlos);
// TriangleTwo.ExtensionMethod(henrique);

//    Square square = new Square();
//    square.side = 2;
//    Console.WriteLine(square.CalcularArea());
// try
// {

// 	// TriangleOne triangleOne = new TriangleOne();
// 	// Console.WriteLine(triangleOne.CalcularArea());
// 	TriangleOne.SetNumPaginas(-10);
// }
// catch (TriangleOneException e)
// {
// 	Console.WriteLine(e.Message);				
// }
// Circumference circumference = new Circumference();
// Console.WriteLine(circumference.CalcularArea());
// Trapeze trapeze = new Trapeze();
// trapeze.CalcularArea();
// Criação da turma
// 	Turma turma = new Turma();

