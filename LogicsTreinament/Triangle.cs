using System;

namespace CSharp
{
    public class Triangle
    {
        public int SideA = 7;
        public int SideB = 6;
        public int SideC = 6;
        bool message = true;
        
        public bool isTriangle()
        {
             
            if (!(SideA < SideB + SideC) && (SideB < SideA + SideC) && (SideC < SideA + SideB)) 
            {
                message = false;
            }           
                return message;
        }

        public bool equilatero(){
            if ((SideA == SideB) && (SideB == SideC))
            {
                message = true;
            }
            return message;
        }

        public bool isosceles(){
            if ((SideA == SideB) || (SideA == SideC) || (SideB == SideC)) 
            {
                message = true;
            }
            return message;
        }
        
        public void escaleno(){
            if ((SideA != SideB) && (SideB != SideC) && (SideA != SideC)) 
            {
                System.Console.WriteLine("Escaleno");
            }
        }     
    }
}