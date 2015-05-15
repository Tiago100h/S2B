using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_ProjetoMIC
{
    public partial class EditarCliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var db = new MICEntities();
                
                DDL_Profissoes.DataSource = db.Profissoes.ToList();
                DDL_Profissoes.DataBind();

                if (RetornaCodigoCliente() != null)
                {
                    int Codigo = RetornaCodigoCliente().Value;

                    Clientes cliente = db.Clientes.First(c => c.cd_Cliente == Codigo);

                    CaixaTexto_Nome.Text = cliente.Nome;
                    DDL_Profissoes.SelectedValue = cliente.cd_Profissao.ToString();
                    CaixaTexto_Endereco.Text = cliente.Endereco;
                    CaixaTexto_Bairro.Text = cliente.Bairro;
                    CaixaTexto_Cidade.Text = cliente.Cidade;
                    DDL_UF.SelectedValue = cliente.UF;
                    CaixaTexto_CEP.Text = cliente.CEP;
                    CaixaTexto_LimiteCompras.Text = cliente.LimiteCompras.ToString();
                    CaixaTexto_LimiteCredito.Text = cliente.LimiteCredito.ToString();
                    CaixaTexto_DataNascimento.Text = cliente.DtNascimento.Value.ToString("dd/MM/yyyy");
                }
            }
        }

        private int? RetornaCodigoCliente()
        {
            if (Request.QueryString["cd_Cliente"] != null)
                return Convert.ToInt32(Request.QueryString["cd_Cliente"]);
            else
                return null;
        }
        
        protected void Botao_Salvar_Click(object sender, EventArgs e)
        {
            var db = new MICEntities();
            Clientes cliente;

            if (RetornaCodigoCliente() == null)
                cliente = new Clientes();
            else
            { 
                int Codigo = RetornaCodigoCliente().Value;
                cliente = db.Clientes.First(c => c.cd_Cliente == Codigo);
            }
            
            cliente.Nome = CaixaTexto_Nome.Text;
            cliente.cd_Profissao = Convert.ToInt32(DDL_Profissoes.SelectedValue);
            cliente.Endereco = CaixaTexto_Endereco.Text;
            cliente.Bairro = CaixaTexto_Bairro.Text;
            cliente.Cidade = CaixaTexto_Cidade.Text;
            cliente.UF = DDL_UF.SelectedValue;
            cliente.CEP = CaixaTexto_CEP.Text;
            cliente.LimiteCompras = Convert.ToDecimal(CaixaTexto_LimiteCompras.Text);
            cliente.LimiteCredito = Convert.ToDecimal(CaixaTexto_LimiteCredito.Text);
            cliente.DtNascimento = Convert.ToDateTime(CaixaTexto_DataNascimento.Text);

            if (RetornaCodigoCliente() == null)
                db.Clientes.Add(cliente);

            db.SaveChanges();

            Response.Redirect("Default.aspx");
        }

        protected void Botao_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        
    }
}