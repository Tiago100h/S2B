using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Aula07parte3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var db = new MICEntities();

                var query = (from c in db.Clientes where c.Nome.Substring(0,1).ToUpper() == "C" orderby c.Nome select c).ToList();

                GridView2.DataSource = query;
                GridView2.AutoGenerateColumns = true;
                GridView2.DataBind();
            }
        }

        protected void Botao_IncluirPessoa_Click(object sender, EventArgs e)
        {
            var db = new MICEntities();

            Cliente c = new Cliente();

            c.Nome = "Carlos Automático";
            c.UF = "MG";
            c.Endereco = "Ava Monter Claros, 1471";
            c.Bairro = "Anchieta";
            c.CEP = "31340310";
            c.cd_Profissao = 3;

            db.Clientes.Add(c);
            db.SaveChanges();
        }
    }
}