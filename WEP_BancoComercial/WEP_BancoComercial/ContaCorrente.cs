using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetodosBancoComercial.Conta.Corrente
{
    public class ContaCorrente : Conta
    {
        public double Taxa;
        public double LimiteCredito;
        public double Juros;

        public void CalculaMes()
        {
            Saldo = Saldo - this.Taxa;
                        
        }

    }
}