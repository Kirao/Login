using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia,Digite seu Usuario para Login.. ");
            var nome = Console.ReadLine(); //Digitar o nome do usuario
            Console.WriteLine($"\nOla, {nome}!Digite sua senha.");
            var Senha = Console.ReadLine(); //setar uma senha para o usuario
            Console.WriteLine($"\nOla, {nome}!Confirme sua senha.");
            var pass = Console.ReadLine();//Confirmar a senha do usuario
            
            if(Senha == pass)//execução caso a senha seja correta
            {
              Console.WriteLine("Bem vindo, Guilherme, Tenha um otimo serviço!");                    
             }
            else //execução caso a senha seja incorreta
            {
             Console.WriteLine("Senha incorreta..");             
            }

        }
        
        }
    }