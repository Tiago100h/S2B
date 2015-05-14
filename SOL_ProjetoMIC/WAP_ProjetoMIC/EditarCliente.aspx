<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="WAP_ProjetoMIC.EditarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DDL_Profissoes" runat="server" DataTextField="Nome" DataValueField="cd_Profissao"></asp:DropDownList>
        <br />
        <asp:Label ID="Lbl_Nome" runat="server" Text="Nome: "></asp:Label><asp:TextBox ID="CaixaTexto_Nome" runat="server"></asp:TextBox>    
        <br />
        <asp:Label ID="Lbl_Endereco" runat="server" Text="Endereço: "></asp:Label><asp:TextBox ID="CaixaTexto_Endereco" runat="server"></asp:TextBox>    
        <br />
        <asp:Label ID="Lbl_Bairro" runat="server" Text="Bairro: "></asp:Label><asp:TextBox ID="CaixaTexto_Bairro" runat="server"></asp:TextBox>    
        <br />
        <asp:Label ID="Lbl_Cidade" runat="server" Text="Cidade: "></asp:Label><asp:TextBox ID="CaixaTexto_Cidade" runat="server"></asp:TextBox>    
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br />
        <asp:Label ID="Lbl_CEP" runat="server" Text="CEP: "></asp:Label><asp:TextBox ID="CaixaTexto_CEP" runat="server"></asp:TextBox>    
        <br />
        <asp:Label ID="Lbl_LimiteCompras" runat="server" Text="Limite de Compras: "></asp:Label><asp:TextBox ID="CaixaTexto_LimiteCompras" runat="server"></asp:TextBox>    
        <br />
        <asp:Label ID="Lbl_LimiteCredito" runat="server" Text="Limite de Crédito: "></asp:Label><asp:TextBox ID="CaixaTexto_LimiteCredito" runat="server"></asp:TextBox>    
        <br />
        <asp:Label ID="Lbl_DataNascimento" runat="server" Text="Data de Nascimento: "></asp:Label><asp:TextBox ID="CaixaTexto_DataNascimento" runat="server"></asp:TextBox>    
    </div>
    </form>
</body>
</html>
