<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAP_Aula07parte2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div>   
        <asp:Label ID="Lbl_Nome" runat="server" Text="Nome: "></asp:Label><asp:TextBox ID="CaixaTexto_Nome" runat="server"></asp:TextBox>
        <br />  
        <asp:Label ID="Lbl_Profissao" runat="server" Text="Profissão: "></asp:Label><asp:TextBox ID="CaixaTexto_Profissao" runat="server"></asp:TextBox>
        <br />  
        <asp:CheckBoxList ID="CBL_Interesse" runat="server">
            <asp:ListItem Value="Banco de Dados"></asp:ListItem>
            <asp:ListItem Value="Programação"></asp:ListItem>
            <asp:ListItem Value="Análise"></asp:ListItem>
            <asp:ListItem Value="Infra"></asp:ListItem>
        </asp:CheckBoxList>
        <br />  
        <asp:Button ID="Botao_Aplicar" runat="server" Text="Aplicar" OnClick="Botao_Aplicar_Click" />
    </div>

</asp:Content>
