<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEP_BancoComercial._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Abertura de Conta</h1>
    </div>

    <div class="row">
        
        <asp:Label ID="Label1" runat="server" Text="Banco: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Agência: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="Conta: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        <asp:Label ID="Label4" runat="server" Text="Titular: "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

        <asp:Label ID="Label5" runat="server" Text="Saldo: "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />  

        <asp:Button ID="Button1" runat="server" Text="Conta Corrente" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Conta Poupança" />
        <br />  

        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>

    </div>

</asp:Content>
