<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAP_Aula09._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Aula 09 - Ajax</h1>
    </div>

    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:ListBox ID="LB_Numeros" runat="server"></asp:ListBox>
                <br />
                <asp:TextBox ID="CaixaTexto_Numero" runat="server" TextMode="Number"></asp:TextBox>
                <br />
                <asp:Button ID="Botao_Adicionar" runat="server" Text="Adicionar" OnClick="Botao_Adicionar_Click" />
                <asp:Button ID="Botao_Media" runat="server" Text="Média" OnClick="Botao_Media_Click" />
                <br />
                <asp:Label ID="Lbl_Resultado" runat="server" Text="Média: "></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Button ID="Botao_MediaSemAjax" runat="server" Text="Média" OnClick="Botao_Media_Click" />
    </div>

</asp:Content>
