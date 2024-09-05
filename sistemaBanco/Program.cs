using System;
using System.Globalization;

namespace sistemaBanco {
    class Program {
        static void Main(string[] args) {

            Cliente c;

            Console.WriteLine("Entre com o número da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial?");
            Console.WriteLine("1 - Sim\n" +
                              "2 - Não\n");

            int opcao = int.Parse(Console.ReadLine());

            double saldoinicial = 0.0;

            if (opcao == 1) {

                Console.WriteLine("Digite o valor para depósito: ");
                saldoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Cliente(numeroconta, nome, saldoinicial);
                Console.WriteLine("Dados da conta: " + c);
                Console.WriteLine("Digite um valor para sacar: ");
                double sacar = double.Parse(Console.ReadLine());
                c.Retirar(sacar);
            }
            else if (opcao == 2) {
                c = new Cliente(numeroconta, nome);
                Console.WriteLine($"Dados da conta: {c}");
                Console.WriteLine();
                Console.WriteLine("Entre com um valor para depósito: ");
                double valordeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Depositar(valordeposito);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(c);

                Console.WriteLine("Digite um valor para sacar: ");
                valordeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Retirar(valordeposito);
                Console.WriteLine(c);

            }
            else {
                Console.WriteLine("ERROR Opção Invalida! ");
                Console.WriteLine("DIGITE UMA OPÇÂO DISPONIVEL");
                return;
            }




        }
    }
}