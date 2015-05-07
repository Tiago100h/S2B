using MinhasClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEP_Aula04
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Botao_Caixa_Click(object sender, EventArgs e)
        {
            Caixa cx = new CaixaAvancada();
            Lbl_Resultado.Text = cx.Mostra();
        }
    }
}