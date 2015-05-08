using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetodosBancoComercial.Conta.Corrente
{
    public class ContaCorrente : Conta
    {
        public double Tarifa;
        public double LimiteCredito;
        public double TaxaJuros;

        public ContaCorrente (double tarifa = 50, double limiteCredito = 1000, double taxajuros = 7):base()
        {
            this.Tarifa = tarifa;
            this.LimiteCredito = limiteCredito;
            this.TaxaJuros = taxajuros;
        }
               
        public override void CalcularMes()
        {
            Saldo -= Tarifa;

            if (Saldo < 0)
            {
                Saldo = Saldo - (Saldo * TaxaJuros / 100);
            }
        }

    }
}