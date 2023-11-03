using System;

namespace CSharp
{
  public struct Fracao {
    public double numerador;
    public double denominador;    

  public double CalculaFracao(){
    if (denominador == 0)
    {
      return 0;
    }
      return numerador / denominador;
  }

  public Fracao Multiplicar(Fracao f) {
    Fracao result = new Fracao();

    result.numerador = numerador * f.numerador;
    result.denominador = denominador * f.denominador;
    return result;
  }  
    public Fracao(double numerador, double denominador) {
      this.numerador = numerador;
      this.denominador = denominador;
    }

    public override string ToString () {
      return numerador + " * " + denominador;
    }
  }
}

/* Código para executar no main
Fracao f1 = new Fracao(5,2);
          Fracao f2 = new Fracao(3,7);

          Fracao f3 = f1.Multiplicar(f2);
          Console.WriteLine(f3);            
          Console.WriteLine(f3.CalculaFracao());
*/