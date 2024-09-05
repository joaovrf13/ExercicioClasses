using System.Globalization;


namespace sistemaBanco
{
    internal class Cliente
    {

        private string Nome { get; set; }
        private int NumeroConta { get; set; }
        private double Saldo { get; set; }

        public Cliente(string nome, int numeroConta, double saldo)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public Cliente(int numeroconta, string nome)
        {

            NumeroConta = numeroconta;
            Nome = nome;
        }

        public Cliente(int numeroconta, string nome, double depositoInicial)
        {
            Depositar(depositoInicial);
        }



        public void Depositar(double valor)
        {
            Saldo += valor;

        }

        public void Retirar(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Número da conta:  "
                   + NumeroConta.ToString()
                   + ", "
                   + " Nome do titular: "
                   + Nome
                   + ", "
                   + "Saldo: "
                   + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
