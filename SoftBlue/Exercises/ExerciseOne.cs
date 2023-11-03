using System;

namespace CSharp
{
  public class Relogio {
    public Ponteiro ponteiroHora = new Ponteiro();
    public Ponteiro ponteiroMinuto = new Ponteiro();
    public Ponteiro ponteiroSegundo = new Ponteiro();
  public void  AcertarRelogio(int hora, int minuto, int segundo) {
    ponteiroHora.posicao = hora;
    ponteiroMinuto.posicao = minuto;
    ponteiroSegundo.posicao = segundo;
    
  }

    public int LerHora()
    {
      return ponteiroHora.posicao;
    }

    public int LerMinuto()
    {
      return ponteiroMinuto.posicao;
    }

    public int LerSegundo()
    {
      return ponteiroSegundo.posicao;
    }


  }
  public class Ponteiro {
    public int posicao;
  }
}

/* Código para executar no main
    Relogio relogio = new Relogio();
            relogio.AcertarRelogio(23, 52, 19);

            Console.WriteLine(relogio.LerHora());
            Console.WriteLine(relogio.LerMinuto());
            Console.WriteLine(relogio.LerSegundo());
            Console.WriteLine($" A hora atual é {relogio.LerHora()}: {relogio.LerMinuto()}: {relogio.LerSegundo()}");     
            DateTime timeNow = DateTime.Now;
            string teste = ($" {timeNow.Hour}0: {timeNow.Minute}: {timeNow.Second}");  
            System.Console.WriteLine(teste);
*/