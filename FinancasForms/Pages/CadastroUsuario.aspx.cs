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
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Login.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nome = txbNome.Text,
                Email = txbEmail.Text,
                Senha = txbSenha.Text
            };

            var result = new UsuarioBusiness(new UsuarioRepositoy()).InsertUsuario(usuario);
            if (result == 1)
            {
                Response.Redirect("/Pages/Login.aspx");
            }
            else
            {
                lblAlerta.Text = "Usuário já cadastrado!";
            }
        }
    }
}