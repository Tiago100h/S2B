using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_ProjetoMIC
{
    public partial class _Default : Page
    {

        private void AtualizaGrid()
        {
            var db = new MICEntities();

            var query = db.Clientes.Join(db.Profissoes,
                cliente => cliente.cd_Profissao,
                profissao => profissao.cd_Profissao, (cliente, profissao) => new { cliente.cd_Cliente, cliente.Nome, cliente.Cidade, cliente.UF, NomeProfissao = profissao.Nome }).ToList();

            GridView_Clientes.DataSource = query;

            GridView_Clientes.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AtualizaGrid();
            }
        }

        protected void Botao_Pesquisar_Click(object sender, EventArgs e)
        {
            var db = new MICEntities();

            var query = db.Clientes.Where(cliente => cliente.Nome.StartsWith(CaixaTexto_Pesquisa.Text)).Join(db.Profissoes,
                    cliente => cliente.cd_Profissao,
                    profissao => profissao.cd_Profissao, (cliente, profissao) => new 
                    { cliente.cd_Cliente, cliente.Nome, cliente.Cidade, cliente.UF, NomeProfissao = profissao.Nome }).ToList();

            GridView_Clientes.DataSource = query;
            GridView_Clientes.DataBind();
        }

        protected void Botao_Adicionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarCliente.aspx");
        }

        protected void Botao_Editar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(GridView_Clientes.SelectedDataKey.Value);
            Response.Redirect("CadastrarCliente.aspx?cd_Cliente=" + Codigo.ToString());
        }

        protected void Botao_Apagar_Click(object sender, EventArgs e)
        {
            if (GridView_Clientes.SelectedDataKey != null)
            {
                if (GridView_Clientes.SelectedDataKey != null)
                {
                    int Codigo = Convert.ToInt32(GridView_Clientes.SelectedDataKey.Value);
                    var db = new MICEntities();
                    Clientes cliente = db.Clientes.First(c => c.cd_Cliente == Codigo);
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                    AtualizaGrid();
                }
            }
        }
    }
}