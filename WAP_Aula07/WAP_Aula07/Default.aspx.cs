using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Aula07
{
    public partial class _Default : Page
    {
        public int a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Botao_AtribuiA_Click(object sender, EventArgs e)
        {
            this.a = Convert.ToInt32(CaixaTexto_A.Text);
            Session.Add("a", this.a);
        }

        protected void Botao_AtribuiB_Click(object sender, EventArgs e)
        {
            this.b = Convert.ToInt32(CaixaTexto_B.Text);
            Session.Add("b", this.b);
        }

        protected void Botao_Soma_Click(object sender, EventArgs e)
        {
            this.a = Convert.ToInt32(Session["a"]);
            this.b = Convert.ToInt32(Session["b"]);
            Lbl_Resultado.Text = (this.a + this.b).ToString();
        }

        protected void Botao_Adiciona_Click(object sender, EventArgs e)
        {
            LB.Items.Add(CaixaTexto.Text);
            CaixaTexto.Text = string.Empty;
        }

        protected void Botao_GravaCookie_Click(object sender, EventArgs e)
        {
            HttpCookie Cookie = new HttpCookie("MeuCookie");
            Cookie.Expires = System.DateTime.Now.AddDays(1);
            Cookie.Value = CaixaTexto_Nome.Text;
            Response.Cookies.Add(Cookie);
        }

        protected void Botao_RecuperaCookie_Click(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["MeuCookie"];
            Lbl_ResultadoNome.Text = c.Value;
        }
    }
}