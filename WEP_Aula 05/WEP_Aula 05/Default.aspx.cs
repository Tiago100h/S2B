using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEP_Aula_05
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            carro.Nome = TextBox1.Text;
            carro.Marca = (Marcas)Enum.Parse(typeof(Marcas), DropDownList1.SelectedValue);
            carro.setVelocidade(Convert.ToInt32(TextBox2.Text));

            Label4.Text = carro.DadosCarro();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CarroAvancado ca = new CarroAvancado();
            ca.Nome = TextBox1.Text;
            ca.Marca = (Marcas)Enum.Parse(typeof(Marcas), DropDownList1.SelectedValue);
            ca.Velocidade = Convert.ToInt32(TextBox2.Text);

            Label4.Text = ca.DadosCarroAvancado();
        }
    }
}