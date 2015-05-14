using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Aula09
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Botao_Adicionar_Click(object sender, EventArgs e)
        {
            LB_Numeros.Items.Add(CaixaTexto_Numero.Text);
            CaixaTexto_Numero.Text = String.Empty;
        }

        protected void Botao_Media_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "Média: ";
            double resultado = 0;
            for (int i = 0; i < LB_Numeros.Items.Count; i++)
            {
                resultado += Convert.ToDouble(LB_Numeros.Items[i].Value);
            }
            Lbl_Resultado.Text += (resultado / Convert.ToDouble(LB_Numeros.Items.Count)).ToString();
        }
    }
}