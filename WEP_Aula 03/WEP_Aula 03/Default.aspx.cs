using MinhasClasses.Caixa;
using MinhasClasses.Caixa.Colorida;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEP_Aula_03
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Botao_CaixaSimples_Click(object sender, EventArgs e)
        {
            Caixa cx; //Variável de instância
            cx = new Caixa();
            //cx.Altura = 10;
            //cx.Largura = 20;
            //cx.Comprimento = 30;
            Lbl_Volume.Text = cx.CalculaVolume().ToString();
            Lbl_Area.Text = cx.CalculaArea().ToString();
        }

        protected void Botao_caixaUnica_Click(object sender, EventArgs e)
        {            
            Lbl_Volume.Text = new Caixa(40, 40, 80).CalculaVolume().ToString();
        }

        protected void Botao_CaixaColorida_Click(object sender, EventArgs e)
        {
            CaixaColorida cc = new CaixaColorida();
            cc.Altura = Convert.ToInt32(Txb_Altura.Text);
            cc.Largura = Convert.ToInt32(Txb_Largura.Text);
            cc.Comprimento = Convert.ToInt32(Txb_Comprimento.Text);

            switch (DDL_Cor.SelectedIndex)
            {
                case 0:
                    cc.Cor = Color.Red;
                    break;
                case 1:
                    cc.Cor = Color.Blue;
                    break;
                case 2:
                    cc.Cor = Color.Green;
                    break;                   
            }
            Lbl_CaixaColorida.Text = String.Format("A caixa foi criada e tem volume {0} e área {1}",
                cc.CalculaVolume().ToString(),
                cc.CalculaArea().ToString());
            Lbl_CaixaColorida.ForeColor = cc.Cor;
        }
    }
}