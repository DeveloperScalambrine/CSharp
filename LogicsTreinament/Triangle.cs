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
// Novas funcionalidades adicionadas