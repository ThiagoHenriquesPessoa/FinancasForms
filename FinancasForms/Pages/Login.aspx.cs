using DataAccess.Repository;
using Domain.Business;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinancasForms.Pages
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nome = "",
                Email = txbEmail.Text,
                Senha = txbSenha.Text
            };
            var result = new UsuarioBusiness(new UsuarioRepositoy()).GetListUsuario(usuario);
            if (result)
            {
                Response.Redirect("/Pages/Home.aspx");
            }
            else
            {
                lblMensagemErro.Text = "Credenciais inválidas. Verifique seu e-mail e senha.";
            }
        }

        protected void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/CadastroUsuario.aspx");
        }
    }
}