<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_Aula02.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DDL_Dados" runat="server"></asp:DropDownList>
        <asp:Label ID="LabelTotal" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:ListBox ID="LB_Marcas" runat="server"></asp:ListBox>
        <br />
        <asp:TextBox ID="TB_Marca" runat="server"></asp:TextBox>
        <asp:Button ID="Botao_Incluir" runat="server" Text="Incluir" OnClick="Botao_Incluir_Click" />
        <br />
        <asp:Button ID="Botao_CarregarArray" runat="server" Text="Carregar Array" Width="166px" OnClick="Botao_CarregarArray_Click" />
        <asp:Button ID="Botao_Lambda" runat="server" Text="Lambda" OnClick="Botao_Lambda_Click" />
        <asp:Button ID="Botao_Linq" runat="server" Text="Linq" OnClick="Botao_Linq_Click" />
    </div>
    </form>
</body>
</html>
