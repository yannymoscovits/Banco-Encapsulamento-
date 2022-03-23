using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            double depositoinicial;

            Console.WriteLine("Seja Bem-Vindo(a) ao Banco Moscovits! Para se cadastrar forneça os dados abaixo!" );

            Console.WriteLine("Entre com o numero da conta : ");
            int numeroconta = int.Parse( Console.ReadLine() );
            Console.WriteLine("Entre o titular da conta: ");
            string titularconta = Console.ReadLine();
            Console.WriteLine("Havéra deposito inicial?");
            string escolha = Console.ReadLine();

            if (escolha == "s")
            {
                Console.Write("Entre o valor de depósito inicial : ");
                depositoinicial = double.Parse( Console.ReadLine() );
               
            }
            else
            {
                depositoinicial = 0.0;
                
            }
            
            Cadastro c1 = new Cadastro(numeroconta, titularconta, depositoinicial);

            Console.WriteLine("Dados da Conta : ");
            Console.WriteLine("Conta: " + numeroconta + ", " + " Titular: " + titularconta + ", " + " Saldo: " + depositoinicial.ToString("F2"));

            Console.WriteLine("Entre com um valor de deposito :");
            double add = double.Parse( Console.ReadLine() );
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine("Conta: " + numeroconta + ", " + " Titular: " + titularconta + ", " + " Saldo: " + c1.Deposito(add).ToString("F2"));

            Console.WriteLine("Entre com um valor de saque :");
            double sub = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Conta atualizados : ");
            Console.WriteLine("Conta: " + numeroconta + ", " + " Titular: " + titularconta + ", " + " Saldo: " + c1.Saque(sub).ToString("F2"));

        }
    }
}