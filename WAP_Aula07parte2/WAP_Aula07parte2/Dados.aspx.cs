using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Aula07parte2
{
    public partial class Dados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["DadosUsuario"] != null)
            {
                Pessoa pessoa;
                pessoa = (Session["DadosUsuario"] as Pessoa);
                Lbl_Nome.Text += pessoa.Nome;
                Lbl_Profissao.Text += pessoa.Profissao;
                if (pessoa.BancoDados)
                    Lbl_Interesses.Text += "Banco de Dados ";
                if (pessoa.Programacao)
                    Lbl_Interesses.Text += "Programação ";
                if (pessoa.Analise)
                    Lbl_Interesses.Text += "Análise ";
                if (pessoa.Infra)
                    Lbl_Interesses.Text += "Infra ";
            }
        }

        protected void Botao_voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Botao_resetar_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}