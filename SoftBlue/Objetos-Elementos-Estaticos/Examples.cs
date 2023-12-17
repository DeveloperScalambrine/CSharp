using System;

namespace CSharp
{
  public class ObjEleStatics
  {
    // public string firstChildren;
    // public string secondChildren;
    // public string thirdChildren;

    // public int AgeJ;
    // public int AgeP;
    // public int AgeS;
  
    // public ObjEleStatics() {
    //   firstChildren = string.Empty;
    //   secondChildren = string.Empty;
    //   thirdChildren = string.Empty;
    // }

    // public ObjEleStatics(string nameJ, string nameP, string nameS) {
    //   firstChildren = nameJ;
    //   secondChildren = nameP;
    //   thirdChildren = nameS;
    // }
    // public ObjEleStatics(int ageJ, int ageP, int ageS) : this("João","Pedro","Sarah"){
    //   AgeJ = ageJ;
    //   AgeP = ageP;
    //   AgeS = ageS; 
      
    // }
        // public override string ToString()
        // {
        //     return $"Filho mais velho => é o {firstChildren} com {AgeJ} de idade: => {secondChildren} é o filho do meio com {AgeP} de idade: Por ultimo tem a Filha mais nova => {thirdChildren} com {AgeS} de idade";
        // }
    
        /// <summary>
        /// This field for will change in the method NotifyOPerator
        /// </summary>
        public static bool Communication = true;

        /// <summary>
        /// This method received the return of NotifyOperator
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool PayOrder(bool operation)
        {
          NotifyOperator();
          operation = Communication ? true : throw new ArgumentException("Erro ao tentar se conectar com a operadora");
          
          if (operation)
          {
            Console.WriteLine("Comunicação bem sucedida");
          }
          return operation;
    }

    /// <summary>
    /// This method to change the field Communication
    /// </summary>
    /// <returns></returns>
    public static bool NotifyOperator()
      {
        if (Communication == false)
        {
          Communication = true;
          return Communication;
        }
        Communication = false;
        return Communication;
      }
  }
}
/*
Código para executar no main
 ObjEleStatics.PayOrder(ObjEleStatics.Communication);
 ObjEleStatics objEleStatics = new ObjEleStatics(16,10,7);
            if (objEleStatics.firstChildren == string.Empty)
            {
                Console.WriteLine("Construtor vazio sem nomes e idades");
            } else if(objEleStatics.AgeJ == 0) {
                Console.WriteLine("Construindo apenas nomes");
            } else {
                Console.WriteLine($"Filho mais velho => é o {objEleStatics.firstChildren} com {objEleStatics.AgeJ} de idade: => {objEleStatics.secondChildren} é o filho do meio com {objEleStatics.AgeP} de idade: Por ultimo tem a Filha mais nova => {objEleStatics.thirdChildren} com {objEleStatics.AgeS} de idade");
            }
*/
