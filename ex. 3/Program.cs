using System;

namespace ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            do
            {
                Console.WriteLine("Digite seu nome!!");
                nome = Console.ReadLine();
            } while (nome == "");

            int idade;
            do
            {
                Console.WriteLine("Digite sua idade!!");
                idade = int.Parse(Console.ReadLine());

            } while (idade > 150 || idade < 0);

            double salario;
            do
            {
                 
                Console.WriteLine("Digite seu salário");
                salario = Convert.ToInt32(Console.ReadLine());

            } while (salario < 0);

            string estadoCivil;
            do
            {
                
                Console.WriteLine("Digite seu estado cívil ('s'Solteiro(a)) ('c'Casado(a)) ('d'Divorciado(a)) ('v'Viuvo(a))"); 
                estadoCivil = Console.ReadLine();  

                if(estadoCivil == "s"  || estadoCivil == "c" || estadoCivil == "d" || estadoCivil == "v"){
                    estadoCivil = "s";
                }

            } while (estadoCivil != "s");
             Console.WriteLine("Cadastro concluiuido!!  ");
        }
    }
}
