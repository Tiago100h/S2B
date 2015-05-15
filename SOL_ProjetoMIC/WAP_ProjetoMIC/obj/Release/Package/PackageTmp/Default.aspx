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
                    <asp:GridView ID="GridView_Clientes" runat="server" AutoGenerateColumns="False" DataKeyNames="cd_Cliente">
                        <Columns>
                            <asp:CommandField SelectText="Selecionar" ShowSelectButton="True" />
                            <asp:BoundField DataField="cd_Cliente" HeaderText="Código" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                            <asp:BoundField DataField="UF" HeaderText="UF" />
                            <asp:BoundField DataField="NomeProfissao" HeaderText="Profissão" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Button ID="Botao_Adicionar" runat="server" Text="Adicionar" OnClick="Botao_Adicionar_Click" />
            <asp:Button ID="Botao_Editar" runat="server" Text="Editar" OnClick="Botao_Editar_Click" />
            <asp:Button ID="Botao_Apagar" runat="server" Text="Apagar" OnClick="Botao_Apagar_Click" />
        </div>
    </div>

</asp:Content>
