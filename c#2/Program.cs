using System;

namespace c_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;
            do
            {
                Console.WriteLine("Digite um numero de 0 a 10: ");
                resposta = int.Parse(Console.ReadLine());

            
                if(resposta >=0 && resposta <= 10)
                {

                    Console.WriteLine ("Este valor é valido!!");
                    
                }
                else
                {
                    Console.WriteLine("Digite um numero de 0 a 10: "+resposta);
                 }

                 if(resposta >=10 && resposta <=20)
                 {
                    Console.WriteLine ("Este valor é invalido!!");
                 }

            } while (resposta >= 10);
            {
                Console.WriteLine("");            
            }            
        }
    }
}

