using System;

namespace CSharp

{
    public static class AverageWithCondition
    {
        public static double N1 { get; set; }
        public static double N2 { get; set; }
        public static double N3 { get; set; }
        public static double N4 { get; set; }
        private static string Situation;
        public static double result;
 
    
        public static void averageNote(double n1, double n2, double n3, double n4)
        {
            Console.WriteLine("Digite a primeira nota");
            n1 = double.Parse(Console.ReadLine());
            N1 = n1;
            Console.WriteLine("Digite a segunda nota");
            n2 = double.Parse(Console.ReadLine());
            N2 = n2;
            Console.WriteLine("Digite a terceira nota");
            n3 = double.Parse(Console.ReadLine());
            N3 = n3;
            Console.WriteLine("Digite a quarta nota");
            n4 = double.Parse(Console.ReadLine());
            N4 = n4;
            result = (N1 + N2 + N3 + N4) / 4;
            if (result >= 7)
            {
                Situation = "Aprovado";
                showMessage();
                
            } else{
                Situation = "Reprovado";
                showMessage();
            }
        }

        public static void showMessage()
        {
            if (Situation == "Aprovado")
            {
                Console.WriteLine($"Parabens voce foi {Situation} com a nota {result}");
                
            }
            else
            {
                Console.WriteLine($"Infelizamente voce foi {Situation} com a nota {result}");
                
            }
            
        }
    }
}