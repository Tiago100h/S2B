using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_Aula02
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] tipoAutomovel = { "Carro", "Caminhão", "Moto", "Bicicleta" };
                PopulaDropDown(tipoAutomovel);
            }
        }

        private void PopulaDropDown(string[] meuArray)
        {
            DDL_Dados.DataSource = meuArray;
            DDL_Dados.DataBind();
            LabelTotal.Text = "Total de itens: " + meuArray.Length.ToString();
        }

        protected void Botao_Incluir_Click(object sender, EventArgs e)
        {
            LB_Marcas.Items.Add(TB_Marca.Text);
            TB_Marca.Text = String.Empty;
        }

        protected void Botao_CarregarArray_Click(object sender, EventArgs e)
        {
            string[] Marcas = new string[4] { "Fiat", "VW", "Chevrolet", "Ford" };
            for (int i = 0; i < LB_Marcas.Items.Count; i++)
            {
                Array.Resize<string>(ref Marcas, Marcas.Length + 1);
                Marcas[Marcas.Length - 1] = LB_Marcas.Items[i].ToString();
            }
            PopulaDropDown(Marcas);
        }

        protected void Botao_Lambda_Click(object sender, EventArgs e)
        {
            string[] nome = new string[5] { "Tiago", "Carol", "Carlos", "Carlos", "Renata" };
            PopulaDropDown(nome.Where(p => p.Substring(0, 1) == "C").ToArray());
        }

        protected void Botao_Linq_Click(object sender, EventArgs e)
        {
            string[] nome = new string[5] { "Tiago", "Carol", "Carlos", "Carlos", "Renata" };
            PopulaDropDown((from pessoa in nome where pessoa.Substring(0, 1) == "C" select pessoa).ToArray());
        }

    }
}