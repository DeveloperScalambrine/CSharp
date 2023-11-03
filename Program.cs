using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
          Fracao f1 = new Fracao(5,2);
          Fracao f2 = new Fracao(3,7);

          Fracao f3 = f1.Multiplicar(f2);
          Console.WriteLine(f3);            
          Console.WriteLine(f3.CalculaFracao());

        }
    }
}
