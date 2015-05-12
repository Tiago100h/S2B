using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Aula07parte2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["DadosUsuario"] != null)
            {
                Pessoa pessoa;
                pessoa = (Session["DadosUsuario"] as Pessoa);
                CaixaTexto_Nome.Text = pessoa.Nome;
                CaixaTexto_Profissao.Text = pessoa.Profissao;
                if (pessoa.BancoDados)
                    CBL_Interesse.Items[0].Selected = true;
                if (pessoa.Programacao)
                    CBL_Interesse.Items[1].Selected = true;
                if (pessoa.Analise)
                    CBL_Interesse.Items[2].Selected = true;
                if (pessoa.Infra)
                    CBL_Interesse.Items[3].Selected = true;

                Session.Clear();
            }
        }

        protected void Botao_Aplicar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = CaixaTexto_Nome.Text;
            pessoa.Profissao = CaixaTexto_Profissao.Text;
            pessoa.BancoDados = CBL_Interesse.Items[0].Selected;
            pessoa.Programacao = CBL_Interesse.Items[1].Selected;
            pessoa.Analise = CBL_Interesse.Items[2].Selected;
            pessoa.Infra = CBL_Interesse.Items[3].Selected;

            Session.Add("DadosUsuario", pessoa);

            Response.Redirect("Dados.aspx");
        }
    }
}