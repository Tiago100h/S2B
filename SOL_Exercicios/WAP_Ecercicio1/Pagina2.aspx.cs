using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Ecercicio1
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lbl_Erro.Visible = false;
        }

        protected void Botao_Login_Click(object sender, EventArgs e)
        {
            if (TextBox_Usuario.Text == "sup" && TextBox_Senha.Text == "s2b")
                Response.Redirect("Pagina3.aspx");
            else
                Lbl_Erro.Visible = true;
        }
    }
}