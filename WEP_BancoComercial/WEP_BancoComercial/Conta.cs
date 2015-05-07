using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetodosBancoComercial.Conta
{
    public class Conta
    {
        public string Banco;
        public string Agencia;
        public string NumeroConta;
        public string Titular;
        public double Saldo;

        public void Deposito(double Valor)
        {
            Saldo = Saldo + Valor;
        }

        public string MostraInformacoes()
        {
            return string.Format("Banco: {0}\nAgência: {1} Conta: {2}\nTitular: {3}\nSaldo: {4}", Banco, Agencia, NumeroConta, Titular, Saldo);
        }

        public Conta(string banco, string agencia, string numeroConta, string titular, double saldo)
        {
            this.Banco = banco;
            this.Agencia = agencia;
            this.NumeroConta = numeroConta;
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}