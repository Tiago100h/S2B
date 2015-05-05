using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAP_Exercicio2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Ok_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            ListBox1.Items.Clear();
            ListBox1.Items.Add(Label_Nome.Text + Text_Nome.Text);
            ListBox1.Items.Add(Labe_Profissao.Text + DropDownList_Profissao.SelectedValue);
            ListBox1.Items.Add(Labe_Nota.Text + TextBox_Nota.Text + ((Convert.ToDouble(TextBox_Nota.Text)) >= 60 ? " - Aprovado" : " - Reprovado"));
            ListBox1.Items.Add(Labe_Sexo.Text + RBL_Sexo.SelectedValue);
            ListBox1.Items.Add(CheckBox_PagouMatricula.Text + (CheckBox_PagouMatricula.Checked ? " Sim" : " Não"));
        }
    }
}