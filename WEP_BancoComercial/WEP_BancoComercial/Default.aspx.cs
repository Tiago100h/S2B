using MetodosBancoComercial.Conta.Corrente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEP_BancoComercial
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MetodosBancoComercial.Conta.Conta CC;

            CC = new ContaCorrente();

            CC.Banco = TextBox1.Text;
            CC.Agencia = Convert.ToInt32(TextBox2.Text);
            CC.NumeroConta = Convert.ToInt32(TextBox3.Text);
            CC.Titular = TextBox4.Text;
            CC.Saldo = Convert.ToInt32(TextBox5.Text);

            CC.Depositar(100);
            CC.Sacar(1500);
            CC.CalcularMes();

            Label6.Text = CC.MostraInformacoes();

        }
    }
}