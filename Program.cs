using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjEleStatics objEleStatics = new ObjEleStatics(16,10,7);
            if (objEleStatics.firstChildren == string.Empty)
            {
                Console.WriteLine("Construtor vazio sem nomes e idades");
            } else if(objEleStatics.AgeJ == 0) {
                Console.WriteLine("Construindo apenas nomes");
            } else {
                Console.WriteLine($"Filho mais velho => é o {objEleStatics.firstChildren} com {objEleStatics.AgeJ} de idade: => {objEleStatics.secondChildren} é o filho do meio com {objEleStatics.AgeP} de idade: Por ultimo tem a Filha mais nova => {objEleStatics.thirdChildren} com {objEleStatics.AgeS} de idade");
            }
        }
    }
}