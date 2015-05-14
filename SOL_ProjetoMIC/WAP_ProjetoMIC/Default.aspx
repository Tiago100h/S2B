<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAP_ProjetoMIC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
    </div>

    <div class="row">
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="CaixaTexto_Pesquisa" runat="server"></asp:TextBox>
                    <asp:Button ID="Botao_Pesquisar" runat="server" OnClick="Botao_Pesquisar_Click" Text="Pesquisar" />
                    <asp:GridView ID="GridView_Clientes" runat="server"></asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
            
        </div>
    </div>

</asp:Content>
