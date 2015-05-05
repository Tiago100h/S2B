<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="WAP_Ecercicio1.Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Lbl_Usuario" runat="server" Text="Usuário: "></asp:Label>
        <asp:TextBox ID="TextBox_Usuario" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox_Usuario" ErrorMessage="Campo obrigatório"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Lbl_Senha" runat="server" Text="Senha: "></asp:Label>
        <asp:TextBox ID="TextBox_Senha" runat="server" TextMode="Password"></asp:TextBox>    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_Senha" ErrorMessage="Campo obrigatório"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Botao_Login" runat="server" OnClick="Botao_Login_Click" Text="Login" />
    </div>      
        <asp:Label ID="Lbl_Erro" runat="server" Text="Login/Senha inválidos" Visible="False" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
