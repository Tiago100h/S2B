using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetodosBancoComercial.Conta
{
    public abstract class Conta
    {
        public string Banco;
        public int Agencia;
        public int NumeroConta;
        public string Titular;
        public double Saldo;

        public Conta()
        {
            this.Banco = String.Empty;
            this.Agencia = 0;
            this.NumeroConta = 0;
            this.Titular = String.Empty;
            this.Saldo = 0;
        }

        public abstract void CalcularMes();
                
        public virtual string MostraInformacoes()
        {
            return string.Format("Banco: {0}\nAgência: {1} Conta: {2}\nTitular: {3}\nSaldo: ", Banco, Agencia, NumeroConta, Titular, Saldo.ToString("R$ #,##0.00"));
        }

        public virtual void Sacar(double Valor)
        {
            Saldo -= Valor;
        }
        
        public virtual void Depositar(double Valor)
        {
            Saldo += Valor;
        }        
    }
}