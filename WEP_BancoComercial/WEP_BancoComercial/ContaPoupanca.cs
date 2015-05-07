using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetodosBancoComercial.Conta.Poupanca
{
    public class ContaPoupanca : Conta
    {
        public double Juros;

        public void CalculaMes()
        {
            Saldo = Saldo + (Saldo * this.Juros / 100);            
        }

        public bool Saque(double Valor)
        {
            if (Valor > Saldo)
                return false;
            else
            {
                Saldo = Saldo - Valor;
                return true;
            }
            
        }
    }
}