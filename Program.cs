using System;
using senai.OO.exercicio2.Classes;

namespace senai.OO.exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            Contas conta1 = new Contas();

            Console.WriteLine("Olá Clientes!");

            Console.WriteLine("Informe o nome do Primeiro Cliente");
            conta1.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o número de conta de {conta1.Nome}");
            conta1.ndaconta = Console.ReadLine();

            Console.WriteLine($"Informe o saldo de {conta1.Nome}");
            conta1.saldo = float.Parse(Console.ReadLine());
            #endregion

            #region 
            Contas conta2 = new Contas();

            Console.WriteLine("Olá Clientes!");

            Console.WriteLine("Informe o nome do Segundo Cliente");
            conta2.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o número de conta de {conta2.Nome}");
            conta2.ndaconta = Console.ReadLine();

            Console.WriteLine($"Informe o saldo de {conta2.Nome}");
            conta2.saldo = float.Parse(Console.ReadLine());
            #endregion

            #region 
            Contas conta3 = new Contas();

            Console.WriteLine("Olá Clientes!");

            Console.WriteLine("Informe o nome do Terceiro Cliente");
            conta3.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o número de conta de {conta3.Nome}");
            conta3.ndaconta = Console.ReadLine();

            Console.WriteLine($"Informe o saldo de {conta3.Nome}");
            conta3.saldo = float.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine($"O senhor {conta1.Nome} dono da conta n°{conta1.ndaconta} tem o saldo total de R${conta1.saldo}");

            Console.WriteLine($"O senhor {conta2.Nome} dono da conta n°{conta2.ndaconta} tem o saldo total de R${conta2.saldo}");

            Console.WriteLine($"O senhor {conta3.Nome} dono da conta n°{conta3.ndaconta} tem o saldo total de R${conta3.saldo}");
        }
    }
}
