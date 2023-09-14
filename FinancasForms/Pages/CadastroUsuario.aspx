<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="FinancasForms.Pages.CadastroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="/Style/CadastroUsuario.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function validarCampos() {
            var nome = document.getElementById('<%= txbNome.ClientID %>').value;
            var email = document.getElementById('<%= txbEmail.ClientID %>').value;
            var senha = document.getElementById('<%= txbSenha.ClientID %>').value;

            if (nome === "" || email === "" || senha === "") {
                alert('Preencha todos os campos.');
                return false; 
            }
            return true;
        }
    </script>
</head>
<body>
    <section>
        <form id="form1" runat="server" class="login-form">
            <asp:Label ID="Label3" runat="server" Text="Cadastro de Usuário"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox ID="txbNome" runat="server" placeholder="Nome Completo"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmail" runat="server" placeholder="E-mail"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
            <br />
            <asp:TextBox ID="txbSenha" runat="server" placeholder="Senha"></asp:TextBox>
            <br />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Style="margin-top: 1px" OnClick="btnCancelar_Click" />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClientClick="return validarCampos();" OnClick="btnSalvar_Click" />
            <br />
            <asp:Label ID="lblAlerta" runat="server" ForeColor="Red"></asp:Label>
        </form>
    </section>
</body>
</html>