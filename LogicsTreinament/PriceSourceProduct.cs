using System;

namespace CSharp
{
  public class PriceSourceProduct {
    public static void sortProduct(int source) {
      
      double price;
      switch (source)
      {
        case 1:
        price = 250.00;
        Console.WriteLine($" Preço { price } - produto do Sul");
        break;
        case 2:
        price = 350.00;
        Console.WriteLine($" Preço { price } - produto do Norte");
        break;
        case 3:
        price = 450.00;
        Console.WriteLine($" Preço { price } - produto do Leste");
        break;
        case 4:
        price = 550.00;
        Console.WriteLine($" Preço { price } - produto do Oeste");
        break;
        case 5:
        case 6:
        case 25:
        case 26:
        case 27:
        case 28:
        case 29:
        case 30:
        price = 650.00;
        Console.WriteLine($" Preço { price } - produto do Nordeste");
        break;
        case 7:
        case 8:
        case 9:
        price = 750.00;
        Console.WriteLine($" Preço { price } - produto do Sudeste");
        break;
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
        case 16:
        case 17:
        case 18:
        case 19:
        case 20:
        price = 850.00;
        Console.WriteLine($" Preço { price } - produto do Centro-Oeste");
        break;
        default:
        price = 1000.00;
        Console.WriteLine($" Preço { price } - produto Importado");
        break;
      }
    }
  }
}

/* codigo para executar na main
PriceSourceProduct.sortProduct(21);
*/