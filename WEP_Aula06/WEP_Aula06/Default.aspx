<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEP_Aula06._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Aula06</h1>
    </div>

    <asp:Button ID="Botao_Eletros" runat="server" Text="Eletros" OnClick="Botao_Eletros_Click" />
    <asp:TextBox ID="CaixaTexto_EstadoFuncionamento" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />  
    <br />  

    
    <asp:Label ID="Lbl_Nome01" runat="server" Text="Nome: "></asp:Label><asp:TextBox ID="CaixaTexto_Nome01" runat="server"></asp:TextBox>
    <asp:Label ID="Lbl_Idade01" runat="server" Text="Idade: "></asp:Label><asp:TextBox ID="CaixaTexto_Idade01" runat="server"></asp:TextBox>
    <br />  
    <asp:Label ID="Lbl_Nome02" runat="server" Text="Nome: "></asp:Label><asp:TextBox ID="CaixaTexto_Nome02" runat="server"></asp:TextBox>
    <asp:Label ID="Lbl_Idade02" runat="server" Text="Idade: "></asp:Label><asp:TextBox ID="CaixaTexto_Idade02" runat="server"></asp:TextBox>
    <br />  
    <asp:Button ID="Botao_CompararPessoas" runat="server" Text="Comparar as Pessoas" OnClick="Botao_CompararPessoas_Click" /><asp:Label ID="Lbl_Resultado01" runat="server" Text="Resultado01"></asp:Label>
    <br />  
    <asp:Button ID="Botao_OrdenarPessoas" runat="server" Text="Ordenar Pessoas" OnClick="Botao_OrdenarPessoas_Click" /><asp:Label ID="Lbl_Resultado02" runat="server" Text="Resultado02"></asp:Label>
</asp:Content>
