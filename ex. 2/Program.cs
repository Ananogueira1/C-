using System;

namespace ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
          string usuario = "";
            string senha = "";
          do
          {
            Console.WriteLine("Insira seu nome de usuario: ");
            usuario = Console.ReadLine();

            Console.WriteLine("Insira uma senha: ");
            senha= Console.ReadLine();
              
            if(usuario.ToLower() == senha.ToLower()){
                Console.WriteLine("Usuario e senha não podem ser os mesmos!!");
            } else{

            }

          } while (senha.ToLower() == usuario.ToLower());
                Console.WriteLine("Dados salvos com sucesso!!");

        }
        
    }

}
