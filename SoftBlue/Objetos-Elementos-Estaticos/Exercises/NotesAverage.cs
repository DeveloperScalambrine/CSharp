using System;

namespace CSharp
{
  public class Prova
  {
    public double notaParte1;
    public double notaParte2;

    public double CalcularNotaTotal()
    {
      double sum = notaParte1 + notaParte2;
      if (sum > 10.0)
      {
        throw new FieldAccessException("A soma total das provas não pode ser maior que 10.0");
      }
      return sum;
    }
  }
  public class Turma
  {
    public Aluno aluno1;
    public Aluno aluno2;
    public Aluno aluno3;
    public double CalcularMedia(){
      double studentAverage = aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia();
      return studentAverage;
    }
  }

  public class Aluno
  {
    public Prova prova1;
    public Prova prova2;
    public double CalcularMedia() {
      double media = prova1.CalcularNotaTotal() + prova2.CalcularNotaTotal();
      return media / 2;
    }
  }
}