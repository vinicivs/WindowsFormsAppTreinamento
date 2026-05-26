<%@ Page Title="Pesquisar Cep" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormPesquisarCep.aspx.cs" Inherits="WebApplicationTreinamento.WebFormPesquisarCep" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Pesquisa de Cep</h2>

    <asp:Label ID="lblCep" runat="server" Text="Cep"></asp:Label>
    <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
    <asp:Button ID="btnPesquisarCep" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
    <asp:Button ID="btnVoltar" runat="server" Text="Retorno" OnClientClick="history.back(); return false;" />
    <br />
    <asp:GridView ID="gvwDados" runat="server">
    </asp:GridView>
    <br />
    <asp:LinkButton ID="lbnVoltar" runat="server" OnClick="lbnVoltar_Click">Inicial</asp:LinkButton>
        
</asp:Content>



   




