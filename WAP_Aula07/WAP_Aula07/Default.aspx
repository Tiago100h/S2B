<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAP_Aula07._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Aula 07 - Armazenamento de estado</h1>        
    </div>

    <div>
        <asp:TextBox ID="CaixaTexto_A" runat="server"></asp:TextBox><asp:Button ID="Botao_AtribuiA" runat="server" Text="Atribui A" OnClick="Botao_AtribuiA_Click" />
        <br />  
        <asp:TextBox ID="CaixaTexto_B" runat="server"></asp:TextBox><asp:Button ID="Botao_AtribuiB" runat="server" Text="Atribui B" OnClick="Botao_AtribuiB_Click" />
        <br />  
        <asp:Label ID="Lbl_Resultado" runat="server" Text="Resultado"></asp:Label><asp:Button ID="Botao_Soma" runat="server" Text="Soma" OnClick="Botao_Soma_Click" />
    </div>
    <div>   
        <asp:ListBox ID="LB" runat="server"></asp:ListBox><asp:TextBox ID="CaixaTexto" runat="server"></asp:TextBox><asp:Button ID="Botao_Adiciona" runat="server" Text="Adiciona" OnClick="Botao_Adiciona_Click" />
    </div>
    <div>   
        <asp:Label ID="Lbl_Nome" runat="server" Text="Nome: "></asp:Label><asp:TextBox ID="CaixaTexto_Nome" runat="server"></asp:TextBox><asp:Button ID="Botao_GravaCookie" runat="server" Text="Grava Cookie" OnClick="Botao_GravaCookie_Click" />
        <br />  
        <asp:Label ID="Lbl_ResultadoNome" runat="server" Text="Label"></asp:Label><asp:Button ID="Botao_RecuperaCookie" runat="server" Text="Recupera Cookie" OnClick="Botao_RecuperaCookie_Click" />
    </div>

</asp:Content>
