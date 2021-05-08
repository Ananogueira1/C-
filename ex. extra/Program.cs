using System;

namespace ex._extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");

           int numero1 = 0;
            int numero2 = 1;
            int auxiliar;
            for (int i = 0; i < 14; i++){
              
                 auxiliar = numero1;
                numero1 = numero2;
                numero2 = numero1 + auxiliar;

                Console.WriteLine("{0}", numero2);
            }
        }
    }
}
