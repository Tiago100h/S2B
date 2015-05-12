<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dados.aspx.cs" Inherits="WAP_Aula07parte2.Dados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Lbl_Nome" runat="server" Text="Nome: "></asp:Label>
        <br />  
        <asp:Label ID="Lbl_Profissao" runat="server" Text="Profissão: "></asp:Label>
        <br />  
        <asp:Label ID="Lbl_Interesses" runat="server" Text="Interesses: "></asp:Label>
    </div>
        <asp:Button ID="Botao_voltar" runat="server" Text="Voltar" OnClick="Botao_voltar_Click" /><asp:Button ID="Botao_resetar" runat="server" Text="Resetar" OnClick="Botao_resetar_Click" />
    </form>
</body>
</html>
