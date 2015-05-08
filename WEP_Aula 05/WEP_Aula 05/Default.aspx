<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEP_Aula_05._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Carros</h1>        
    </div>

    <div class="row">
        <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />  
        <asp:Label ID="Label3" runat="server" Text="Marca: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="Fiat"></asp:ListItem>
            <asp:ListItem Value="VW"></asp:ListItem>
            <asp:ListItem Value="GM"></asp:ListItem>
            <asp:ListItem Value="Ford"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Velocidade: "></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />  
        <asp:Button ID="Button1" class="btn-nl" runat="server" Text="Cria" OnClick="Button1_Click" />
        <asp:Button ID="Button2" class="btn-nl" runat="server" Text="Avanc." OnClick="Button2_Click"  />
        <asp:Label ID="Label4" runat="server" Text="Resultado"></asp:Label>
    </div>

</asp:Content>
