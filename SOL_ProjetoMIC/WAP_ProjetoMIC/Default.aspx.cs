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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var db = new MICEntities();

                var query = db.Clientes.Select(cliente => cliente).ToList();

                GridView_Clientes.DataSource = query;

                GridView_Clientes.DataBind();
                

            }
        }

        protected void Botao_Pesquisar_Click(object sender, EventArgs e)
        {
            var db = new MICEntities();

            var query = db.Clientes.Where(cliente => cliente.Nome.StartsWith(CaixaTexto_Pesquisa.Text)).ToList();

            GridView_Clientes.DataSource = query;
            GridView_Clientes.DataBind();
        }
    }
}