using System;

namespace CSharp
{

  /*
  Crie uma classe Lampada que possui um field ligada, que indica se a lâmpada está ligada ou desligada.
  Ao construir uma lâmpada, o estado dela (ligada ou desligada) deve ser fornecido. Para ligar e desligar a lâmpada, os métodos Ligar() e Desligar() devem ser chamados, respectivamente. Aliás, esta é a única forma de alterar o estado da lâmpada, já que o field ligada não pode ser acessado de fora da classe.
  A lâmpada também possui um método Imprimir(). Quando chamado, ele mostra as mensagens “Lâmpada ligada” ou “Lâmpada desligada”, dependendo do estado atual.
  Construa uma aplicação que cria uma lâmpada ligada, muda o estado dela e também imprime o estado atual após cada chamada a Ligar() e Desligar().
  */
  public class LightBulb
  {
    string LightBulbIsOn;

    public LightBulb(string state)
    {
      LightBulbIsOn = state;

      if (LightBulbIsOn != "Ligada" && LightBulbIsOn != "Desligada")
      {
        throw new ArgumentException("A Lampada precisa estar Ligada ou Desligada");
      }

      if (LightBulbIsOn == "Ligada")
      {
        On();
      }
      else if (LightBulbIsOn == "Desligada")
        Off();
    }
    public string On()
    {
      LightBulbIsOn = "Ligada";
      Console.WriteLine(StateOfLightBulb());
      return LightBulbIsOn;
    }

    public string Off()
    {
      LightBulbIsOn = "Desligada";
      Console.WriteLine(StateOfLightBulb());
      return LightBulbIsOn;
    }

    public string StateOfLightBulb()
    {
      string msg;
      if (LightBulbIsOn == "Ligada")
      {
        msg = "Lâmpada ligada";
      }
      else
        msg = "Lâmpada Desligada";
      return $"{msg}";
    }
  }
}