using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cadastro
    {
        public int NumerodaConta { get; private set; }
        public string Nome { get; set; }
        public double DepositoInicial { get; set; }

        public Cadastro (int NumerodaConta, string Nome, double DepositoInicial)
        {
            this.NumerodaConta = NumerodaConta;
            this.Nome = Nome;
            this.DepositoInicial = DepositoInicial;
        }

        public double Deposito(double add)
        {
            this.DepositoInicial = this.DepositoInicial + add;
            return this.DepositoInicial;
        }

        public double Saque(double sub)
        {
            this.DepositoInicial = this.DepositoInicial - sub - 5.00;
            return this.DepositoInicial;
        }
    }
}
