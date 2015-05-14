using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAP_Aula09parte2.ConversaoTemperatura;

namespace WAP_Aula09parte2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Botao_Converter_Click(object sender, EventArgs e)
        {
            TemperatureConversionsSoapTypeClient ws = new TemperatureConversionsSoapTypeClient();
            TextBox1.Text = ws.CelciusToFahrenheit(Convert.ToDecimal(TextBox1.Text)).ToString();
        }
    }
}