using System;

namespace CSharp
{
    public class CountList
    {
        public string List{ get; set; }
        string[] lists = new string[3];

       public void actionOne()
       {
           System.Console.WriteLine("Digite o nome de uma lista:");
           List = Console.ReadLine();
           System.Console.WriteLine("-------------------------------");

       }
        public void action()
        {
           for (int i = 0; i < lists.Length; i++)
           {
                actionOne();
                lists[i] = List;
                
           }
            showMessage();
            System.Console.WriteLine("-----------------------------");
            count();
        }

        public void count()
        {
            Console.WriteLine($"{lists.Length} é a quantidade das listas criadas");
        }

        public void showMessage()
        {
            foreach (var item in lists)
            {
                System.Console.WriteLine(item);
            }
        }

        public void showMessageOne()
        {
            foreach (var item in lists)
            {
                // System.Console.WriteLine(lists[2]);
            }
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine(lists[2]);
        }

    } 
}

/*
Código para executar na main

// CountList countList = new CountList();
// countList.action();
// countList.count();
*/            