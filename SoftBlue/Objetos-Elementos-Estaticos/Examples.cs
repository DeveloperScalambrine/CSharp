using System;

namespace CSharp
{
  public class ObjEleStatics
  {
    public string firstChildren;
    public string secondChildren;
    public string thirdChildren;

    public int AgeJ;
    public int AgeP;
    public int AgeS;
  
    public ObjEleStatics() {
      firstChildren = string.Empty;
      secondChildren = string.Empty;
      thirdChildren = string.Empty;
    }

    public ObjEleStatics(string nameJ, string nameP, string nameS) {
      firstChildren = nameJ;
      secondChildren = nameP;
      thirdChildren = nameS;
    }
    public ObjEleStatics(int ageJ, int ageP, int ageS) : this("João","Pedro","Sarah"){
      AgeJ = ageJ;
      AgeP = ageP;
      AgeS = ageS; 
      
    }
        // public override string ToString()
        // {
        //     return $"Filho mais velho => é o {firstChildren} com {AgeJ} de idade: => {secondChildren} é o filho do meio com {AgeP} de idade: Por ultimo tem a Filha mais nova => {thirdChildren} com {AgeS} de idade";
        // }
    }
}
