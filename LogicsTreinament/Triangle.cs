using System;

namespace CSharp
{
    public class Triangle
    {
        public int SideA = 7;
        public int SideB = 4;
        public int SideC = 2;
        
        public bool isTriangle()
        {
            bool message = true;
            if (!(SideA < SideB + SideC) && (SideB < SideA + SideC) && (SideC < SideA + SideB)) 
            {
                message = false;
            }           
                return message;
        }

        public void equilatero(){
            if ((SideA == SideB) && (SideB == SideC))
            {
                System.Console.WriteLine("Equilátero");
            }
        }

        public void isosceles(){
            if ((SideA == SideB) || (SideA == SideC) || (SideB == SideC)) 
            {
                System.Console.WriteLine("Isósceles");
            }
        }
        
        public void escaleno(){
            if ((SideA != SideB) && (SideB != SideC) && (SideA != SideC)) 
            {
                System.Console.WriteLine("Escaleno");
            }
        }     
    }
}