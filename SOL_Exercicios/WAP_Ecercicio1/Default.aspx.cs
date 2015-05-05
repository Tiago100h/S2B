using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Ecercicio1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Lbl_DataHora.Text = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Botão do S2B")            
                Button1.Text = "Botão de Teste";            
            else            
                Button1.Text = "Botão do S2B";        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina2.aspx");
        }
    }
}