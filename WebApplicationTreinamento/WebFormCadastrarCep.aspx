<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormCadastrarCep.aspx.cs" Inherits="WebApplicationTreinamento.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastra de Cep</h2>

        <asp:Label ID="lblCep" runat="server" Text="Cep (*)"></asp:Label>
        <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCep" runat="server" ErrorMessage="Informe o Cep" ControlToValidate="txtCep" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblLogradouro" runat="server" Text="Logradouro (*)"></asp:Label>
        <asp:TextBox ID="txtLogradouro" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogradouro" runat="server" ErrorMessage="Informe o Logradouro" ControlToValidate="txtLogradouro" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblNumero" runat="server" Text="Número"></asp:Label>
        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblComplemento" runat="server" Text="Complemento"></asp:Label>
        <asp:TextBox ID="txtComplemento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblBairro" runat="server" Text="Bairro (*)"></asp:Label>
        <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtBairro" runat="server" ErrorMessage="Informe o Bairro" ControlToValidate="txtBairro" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        
        <asp:Label ID="lblCidade" runat="server" Text="Cidade (*)"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCidade" runat="server" ErrorMessage="Informe a Cidade" ControlToValidate="txtCidade" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblUf" runat="server" Text="UF (*)"></asp:Label>
        <asp:TextBox ID="txtUF" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUf" runat="server" ErrorMessage="Informe a Uf" ControlToValidate="txtUf" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnCadastrarCep" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        <asp:Button ID="btnVoltar" runat="server" Text="Retorno" OnClientClick="history.back(); return false;" />
<br />
</asp:Content>
