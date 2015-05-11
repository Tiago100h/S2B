using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Aula06
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Botao_Lista_Click(object sender, EventArgs e)
        {
            List<int> lista = new List<int>();

            Random aleatorio = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    lista.Add(aleatorio.Next(1, 50));
            //}

            //lista.Sort();
            //Lbl_Resultado.Text = String.Empty;
            
            //Lbl_Resultado.Text = String.Format("A lista ordenada é {0} e {1} possui o número {2}",
            //    String.Join(", ", lista), lista.Contains(Convert.ToInt32(CaixaTexto_Inteiro.Text))?String.Empty:"não", CaixaTexto_Inteiro.Text);

            while (lista.Count != 50)
            {
                int x = aleatorio.Next(1, 50);
                if (!lista.Contains(x))                
                    lista.Add(x);               
            }

            Lbl_Resultado.Text = String.Empty;

            Lbl_Resultado.Text = String.Format("A lista ordenada é {0} e {1} possui o número {2}",
                String.Join(", ", lista), lista.Contains(Convert.ToInt32(CaixaTexto_Inteiro.Text)) ? String.Empty : "não", CaixaTexto_Inteiro.Text);
        }
    }
}