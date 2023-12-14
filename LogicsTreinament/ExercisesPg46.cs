using System;

namespace CSharp
{
  class ExercisesPg46
  {
    // Escreva um algoritmo que leia tres valores inteiros e diferentes e mostre-os em ordem decrescente. Utilize para tal uma seleção encadeada.
    public static int vlr1;
    public static int vlr2;
    public static int vlr3;
    /// <summary>
    /// O metodo realiza a verificação se os valores são iguais
    /// </summary>
    /// <returns>booleano</returns>
    /// <exception cref="ArgumentException"></exception>
    public static bool IsNotEqual()
    {
      Console.WriteLine("Digite o valor um");
      vlr1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Digite o valor dois");
      vlr2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Digite o valor tres");
      vlr3 = Convert.ToInt32(Console.ReadLine());
      if (vlr1 == vlr2 || vlr1 == vlr3 || vlr2 == vlr1 || vlr2 == vlr3)
      {
        throw new ArgumentException("Valores não podem ser iguais");
      }
      return true;
    }
    /// <summary>
    /// Este metodo faz uma comparação dos valores para mostra-los em ordem de
    /// </summary>
    public static void OrderDesc()
    {
      int[] valoresDesc = new int[3];

      if (vlr1 < vlr2 && vlr1 < vlr3)
      {
        if (vlr2 < vlr3)
        {
          valoresDesc[0] = vlr1;
          valoresDesc[1] = vlr2;
          valoresDesc[2] = vlr3;
        }

        if (vlr3 < vlr2)
        {
          valoresDesc[0] = vlr1;
          valoresDesc[1] = vlr3;
          valoresDesc[2] = vlr2;
        }
      }
      if (vlr2 < vlr1 && vlr2 < vlr3)
      {
        if (vlr1 < vlr3)
        {
          valoresDesc[0] = vlr2;
          valoresDesc[1] = vlr1;
          valoresDesc[2] = vlr3;
        }

        if (vlr3 < vlr1)
        {
          valoresDesc[0] = vlr2;
          valoresDesc[1] = vlr3;
          valoresDesc[2] = vlr1;
        }
      }

      if (vlr3 < vlr1 && vlr3 < vlr2)
      {
        if (vlr1 < vlr2)
        {
          valoresDesc[0] = vlr3;
          valoresDesc[1] = vlr1;
          valoresDesc[2] = vlr2;
        }
        if (vlr2 < vlr1)
        {
          valoresDesc[0] = vlr3;
          valoresDesc[1] = vlr2;
          valoresDesc[2] = vlr1;
        }
      }
      foreach (var item in valoresDesc)
      {
        Console.WriteLine("---");
        Console.WriteLine(item);
      }
    }

    // Desenvolva um algoritmo que calcule as raizes de uma equação do segundo grau, na forma ax2 + bx + c, levando em consideração a existência de raizes reais:
    public static void CalcularRaizes()
    {
      double a = 5;
      double b = -4;
      double c = 1;


      double delta = b * b - 4 * a * c;
      if (delta >= 0)
      {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Raiz 1: " + x1);
        Console.WriteLine("Raiz 2: " + x2);
      }
      else
      {
        Console.WriteLine("Não existem raízes reais");
      }
    }

    /* Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
    para homens(72.7 * h) - 58
    para mulheres(62.1 * h) - 44.7
    */

    public static string IdealWeight()
    {
      double height, weight;
      Console.WriteLine("Digite seu sexo");
      char genre = Convert.ToChar(Console.ReadLine());
      if(genre != 'h' && genre != 'f') throw new AccessViolationException("Genero não localizado");
      if (genre == 'h')
      {
        Console.WriteLine("Digite sua altura");
        height = Convert.ToDouble(Console.ReadLine());
        weight = (72.7 * height) - 58;
      } else 
        {
        Console.WriteLine("Digite sua altura");
        height = Convert.ToDouble(Console.ReadLine());
        weight = (62.1 * height) - 44.7;
      }
        return $"Seu peso ideal é {weight}";
    }

  }
}