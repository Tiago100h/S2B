<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAP_Aula07parte3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Aula 07</h1>
        <p class="lead">Acesso a Dados.</p>
    </div>

        
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="cd_Cliente" DataSourceID="SqlDtS_Clientes" ForeColor="Black" GridLines="Horizontal" PageSize="5">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="cd_Cliente" HeaderText="cd_Cliente" InsertVisible="False" ReadOnly="True" SortExpression="cd_Cliente" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
                    <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
                    <asp:BoundField DataField="UF" HeaderText="UF" SortExpression="UF" />
                    <asp:BoundField DataField="DtNascimento" HeaderText="DtNascimento" SortExpression="DtNascimento" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView> 
            <asp:SqlDataSource ID="SqlDtS_Clientes" runat="server" ConnectionString="<%$ ConnectionStrings:MICConnectionString %>" SelectCommand="SELECT [cd_Cliente], [Nome], [Endereco], [Cidade], [UF], [DtNascimento] FROM [Clientes] ORDER BY [Nome]"></asp:SqlDataSource>
        
        <br />
        <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        

    <asp:Button ID="Botao_IncluirPessoa" runat="server" Text="Incluir Pessoa" OnClick="Botao_IncluirPessoa_Click" />
    




</asp:Content>
