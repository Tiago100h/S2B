using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetodosBancoComercial.Conta.Poupanca
{
    public class ContaPoupanca : Conta
    {
        private double TaxaRendimento;

        public ContaPoupanca():base()
        {
            TaxaRendimento = 5;
        }

        public override void CalcularMes()
        {
            Saldo *= 1 + (TaxaRendimento / 100);
        }
    }
}