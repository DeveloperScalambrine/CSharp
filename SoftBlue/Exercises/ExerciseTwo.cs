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