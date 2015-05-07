<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEP_Aula04._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       
    </div>

    <div class="row">
        <asp:Button ID="Botao_Caixa" runat="server" Text="Caixa" OnClick="Botao_Caixa_Click" />
        <asp:Label ID="Lbl_Resultado" runat="server" ></asp:Label>
    </div>

</asp:Content>
