<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAP_Aula06._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    </div>

    <asp:Button ID="Botao_Lista" runat="server" Text="Lista" OnClick="Botao_Lista_Click" /><asp:TextBox ID="CaixaTexto_Inteiro" runat="server"></asp:TextBox>
    <asp:Label ID="Lbl_Resultado" runat="server" Text="Label"></asp:Label>

</asp:Content>
