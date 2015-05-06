<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEP_Aula_03._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Button ID="Botao_CaixaSimples" runat="server" Text="Caixa Simples" OnClick="Botao_CaixaSimples_Click" /><asp:Label ID="Lbl_Volume" runat="server" Text="Volume: "></asp:Label>
        <asp:Label ID="Lbl_Area" runat="server" Text="Area: "></asp:Label>
    </div>
    <div>
        <asp:Button ID="Botao_caixaUnica" runat="server" Text="Caixa Única" OnClick="Botao_caixaUnica_Click"/>
    </div>
    <div>
        <asp:Label ID="Lbl_Altura" runat="server" Text="Altura: "></asp:Label>
        <asp:TextBox ID="Txb_Altura" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_Comprimento" runat="server" Text="Comprimento: "></asp:Label>
        <asp:TextBox ID="Txb_Comprimento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_Largura" runat="server" Text="Largura: "></asp:Label>
        <asp:TextBox ID="Txb_Largura" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_Cor" runat="server" Text="Cor: "></asp:Label>
        <asp:DropDownList ID="DDL_Cor" runat="server">
            <asp:ListItem Value="Vermelho"></asp:ListItem>
            <asp:ListItem Value="Azul"></asp:ListItem>
            <asp:ListItem Value="Verde"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Botao_CaixaColorida" runat="server" Text="Caixa Colorida" OnClick="Botao_CaixaColorida_Click" />
        <asp:Label ID="Lbl_CaixaColorida" runat="server" Text="Caixa Colorida"></asp:Label>
    </div>
</asp:Content>
