using MinhasClasses.Eletrodomesticos;
using MinhasClasses.Pessoas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEP_Aula06
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Botao_Eletros_Click(object sender, EventArgs e)
        {
            ILigadoDesligado[] arrayEletro = new ILigadoDesligado[3];

            arrayEletro[0] = new Liquidificador();
            arrayEletro[0].Ligar();

            arrayEletro[1] = new ArCondicionado();
            arrayEletro[1].Ligar();

            arrayEletro[2] = new Liquidificador();
            arrayEletro[2].Ligar();

            CaixaTexto_EstadoFuncionamento.Text = arrayEletro[0].EstadoFuncionamento() + " " +
                                                  arrayEletro[1].EstadoFuncionamento() + " " +
                                                  arrayEletro[2].EstadoFuncionamento();
        }

        protected void Botao_CompararPessoas_Click(object sender, EventArgs e)
        {
            #region Criando Objetos
            Pessoas Pessoa1 = new Pessoas();
            Pessoa1.Nome = CaixaTexto_Nome01.Text;
            Pessoa1.Idade = Convert.ToInt32(CaixaTexto_Idade01.Text);

            Pessoas Pessoa2 = new Pessoas();
            Pessoa2.Nome = CaixaTexto_Nome02.Text;
            Pessoa2.Idade = Convert.ToInt32(CaixaTexto_Idade02.Text);
            #endregion

            if (Pessoa1.Equals(Pessoa2))
                Lbl_Resultado01.Text = "Pessoas Iguais";
            else
                Lbl_Resultado01.Text = "Pessoas Diferentes";
        }

        protected void Botao_OrdenarPessoas_Click(object sender, EventArgs e)
        {
            ArrayList arrayPessoas = new ArrayList();

            Pessoas p1 = new Pessoas();
            p1.Nome = "Maria";
            p1.Idade = 14;
            arrayPessoas.Add(p1);

            Pessoas p2 = new Pessoas();
            p2.Nome = "Jõao";
            p2.Idade = 9;
            arrayPessoas.Add(p2);

            Pessoas p3 = new Pessoas();
            p3.Nome = "Tiago";
            p3.Idade = 10;
            arrayPessoas.Add(p3);

            Pessoas p4 = new Pessoas();
            p4.Nome = "Tafnes";
            p4.Idade = 12;
            arrayPessoas.Add(p4);

            Pessoas p5 = new Pessoas();
            p5.Nome = "Goretti";
            p5.Idade = 50;
            arrayPessoas.Add(p5);

            arrayPessoas.Sort();

            Lbl_Resultado02.Text = String.Empty;

            foreach (Pessoas pessoaarray in arrayPessoas)
            {
                Lbl_Resultado02.Text += " " + pessoaarray.Nome + ":" + pessoaarray.Idade.ToString();
            }
        }        

    }
}