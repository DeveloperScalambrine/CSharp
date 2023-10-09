using System;

namespace CSharp
{
    public class Week
    {
        public string dayWeek{ get; set; }

        public Week(string dayWeek)
        {
            this.dayWeek = dayWeek;
        }

        public void action()
        {
            // if (dayWeek == "Semana")
            // {
            //     Console.WriteLine("Levante e vai trabalhar");
            // } else
            // {
            //     Console.WriteLine("Pode ficar deitado mais um pouco");
            // }
        
            switch (dayWeek)
            {
                case "segunda":
                Console.WriteLine("Levante e vai trabalhar");
                break;
                case "terça":
                Console.WriteLine("Levante e vai estudar");
                break;
                case "quarta":
                Console.WriteLine("Levante e vai treinar");
                break;
                case "quinta":
                Console.WriteLine("Levante e vai buscar as crianças");
                break;
                case "sexta":
                Console.WriteLine("Levante e vai jogar");
                break;
                case "sabado":
                Console.WriteLine("Dia dedicado a Deus");
                break;
                case "domingo":
                Console.WriteLine("Pode ficar deitado mais um pouco");
                break;
                default:
                System.Console.WriteLine("Error!!!!");
                break;
            }
        }

    } 
}

/*
Código para executar na main

// Week dayWeek = new Week("sabado");
// dayWeek.action();
*/            
