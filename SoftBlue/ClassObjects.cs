using System;

namespace CSharp
{
    public class ClassObjects
    {
        public int cor;
        public string marca;
        public int anoFabricacao;
        public int corTinta;

        public bool resp;

        // MÉTODO SEM NENHUM TIPO DE RETORNO //
        public void Escrever(string texto){
            Console.WriteLine(texto);
        }

        // METODO COM RETORNO DO TIPO BOOLEAN //
        public bool Abrir(bool situation){
            situation = true;
            resp = situation;
            if (resp == true)
            {
                Console.WriteLine("Caneta aberta");
            } else
            {
                resp = false;
                Console.WriteLine("Caneta fechada");
            }
            return resp;
        }
        public void Fechar(){}
        public void Emprestar(){}
    }
}
/*
Código para executar no main

//    ClassObjects obj = new ClassObjects();
        //    obj.cor = 10; 
        //    obj.marca = "Bic";
        //     //    Console.WriteLine("Foi escrita com a caneta " + obj.marca + " o seguinte texto => ");
        //     //obj.Escrever("Seja feliz meu caro");
        //     obj.Abrir(obj.resp);

*/