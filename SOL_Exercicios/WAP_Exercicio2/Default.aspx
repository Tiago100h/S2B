<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAP_Exercicio2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

    </div>

    <div class="row">
        <div>
            <h2>Exercício 2 - Entre com Seus Dados:</h2>
            <asp:Label ID="Label_Nome" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="Text_Nome" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_Nome" runat="server" ErrorMessage="Escreva o nome" ControlToValidate="Text_Nome" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Labe_Profissao" runat="server" Text="Profissão: "></asp:Label>
            <asp:DropDownList ID="DropDownList_Profissao" runat="server">
                <asp:ListItem Value="Analista">Analista</asp:ListItem>
                <asp:ListItem>Programador</asp:ListItem>
                <asp:ListItem>Gerente</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Labe_Nota" runat="server" Text="Nota: "></asp:Label><asp:TextBox ID="TextBox_Nota" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator_Nota" runat="server" ErrorMessage="Nota deve ser entre 0 e 100" ControlToValidate="TextBox_Nota" MaximumValue="100" MinimumValue="0" SetFocusOnError="True" Type="Integer" ForeColor="Red"></asp:RangeValidator>
        </div>
        <div>
            <asp:Label ID="Labe_Sexo" runat="server" Text="Sexo: "></asp:Label>
            <br />
            <asp:RadioButtonList ID="RBL_Sexo" runat="server" ControlToValidate="RadioButtonList_Sexo">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_Sexo" runat="server" ErrorMessage="Selecione o sexo" ControlToValidate="RBL_Sexo" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:CheckBox ID="CheckBox_PagouMatricula" runat="server" Text="Pagou Matrícula?" />
        </div>
        <div>
            <asp:Button ID="Button_Ok" runat="server" Text="OK" OnClick="Button_Ok_Click" />
        </div>
        <div class="col-md-4">
            <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>
        </div>
    </div>
</asp:Content>
