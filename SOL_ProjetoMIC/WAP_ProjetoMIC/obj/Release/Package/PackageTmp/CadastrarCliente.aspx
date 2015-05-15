<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarCliente.aspx.cs" Inherits="WAP_ProjetoMIC.EditarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Lbl_Nome" runat="server" Text="Nome: "></asp:Label><asp:TextBox ID="CaixaTexto_Nome" runat="server"></asp:TextBox>            
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CaixaTexto_Nome" ErrorMessage="Campo obrigatório!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:DropDownList ID="DDL_Profissoes" runat="server" DataTextField="Nome" DataValueField="cd_Profissao"></asp:DropDownList>            
        <br />
        <asp:Label ID="Lbl_Endereco" runat="server" Text="Endereço: "></asp:Label><asp:TextBox ID="CaixaTexto_Endereco" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="CaixaTexto_Endereco" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Lbl_Bairro" runat="server" Text="Bairro: "></asp:Label><asp:TextBox ID="CaixaTexto_Bairro" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="CaixaTexto_Bairro" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Lbl_Cidade" runat="server" Text="Cidade: "></asp:Label><asp:TextBox ID="CaixaTexto_Cidade" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="CaixaTexto_Cidade" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Lbl_UF" runat="server" Text="UF: "></asp:Label>
        <asp:DropDownList ID="DDL_UF" runat="server">
            <asp:ListItem>ES</asp:ListItem>
            <asp:ListItem>MG</asp:ListItem>
            <asp:ListItem>SP</asp:ListItem>
            <asp:ListItem>RJ</asp:ListItem>
            <asp:ListItem>BA</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Lbl_CEP" runat="server" Text="CEP: "></asp:Label><asp:TextBox ID="CaixaTexto_CEP" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="CaixaTexto_Cidade" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Lbl_LimiteCompras" runat="server" Text="Limite de Compras: "></asp:Label><asp:TextBox ID="CaixaTexto_LimiteCompras" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_LimiteCredito" runat="server" Text="Limite de Crédito: "></asp:Label><asp:TextBox ID="CaixaTexto_LimiteCredito" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_DataNascimento" runat="server" Text="Data de Nascimento: "></asp:Label><asp:TextBox ID="CaixaTexto_DataNascimento" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="CaixaTexto_DataNascimento" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
        <asp:Button ID="Botao_Salvar" runat="server" Text="Salvar" OnClick="Botao_Salvar_Click" /><asp:Button ID="Botao_Cancelar" runat="server" Text="Cancelar" CausesValidation="False" OnClick="Botao_Cancelar_Click" />
    </form>
</body>
</html>
