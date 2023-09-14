<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinancasForms.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="/Style/Login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <section>
        <form id="form1" runat="server" class="login-form">
            <asp:Label ID="Label3" runat="server" Text="Login"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
             <br />
            <asp:TextBox ID="txbEmail" runat="server" placeholder="E-mail"></asp:TextBox>
             <br />
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
             <br />
            <asp:TextBox ID="txbSenha" runat="server" placeholder="Senha"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" Class="button-logar"/>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Ainda não tem conta?  "></asp:Label>
            <asp:Button ID="btnCadastroUsuario" runat="server" Text="Cadastre-se" OnClick="btnCadastroUsuario_Click" Class="button-Cadastro"/>
            <br />
            <br />
        <asp:Label ID="lblMensagemErro" runat="server" ForeColor="Red"></asp:Label>
        </form>
    </section>
</body>
</html>
