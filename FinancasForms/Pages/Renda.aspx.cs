using DataAccess.Repository;
using Domain.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinancasForms.Pages
{
    public partial class Renda : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExibirLista();
        }

        protected void btnNovaRenda_Click(object sender, EventArgs e)
        {
            Exibirformulario();
        }

        private void ExibirLista()
        {
            btnNovaRenda.Visible = true;
            pnlFormularioAddRenda.Visible = false;
            pnlFormularioEditarRenda.Visible = false;
            pnlListaRenda.Visible = true;
            ListaRenda();
        }
        private void Exibirformulario()
        {
            btnNovaRenda.Visible = false;
            pnlFormularioAddRenda.Visible = true;
            pnlFormularioEditarRenda.Visible = false;
            pnlListaRenda.Visible = false;
        }

        private void ExibirformularioEdit(string valorRenda, string tipoRenda, string dataEntrada)
        {
            btnNovaRenda.Visible = false;
            pnlFormularioAddRenda.Visible = false;
            pnlFormularioEditarRenda.Visible = true;
            pnlListaRenda.Visible = false;
            txbValorRenda.Text = valorRenda;
            ddlTipoRenda.SelectedValue = tipoRenda;
            txtDataEntrada.Text = dataEntrada;
        }

        private void ListaRenda()
        {
            gvRenda.DataSource = new RendaBusiness(new RendaRepository()).GetListRendaTotal();
            gvRenda.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txbValorRenda.Text = "";
            ddlTipoRenda.SelectedValue = "";
            txtDataEntrada.Text = DateTime.Now.ToString();
            ExibirLista();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var renda = new Entidades.Models.Renda
            {
                dblValorRenda = txbValorRenda.Text != "" ? Convert.ToDouble(txbValorRenda.Text) : 0,
                txtTipoRenda = ddlTipoRenda.Text != "" ? ddlTipoRenda.Text : "Outros",
                dteDataEntrada = Convert.ToDateTime(txtDataEntrada.Text)
            };
            new RendaBusiness(new RendaRepository()).InsertRenda(renda);
            ExibirLista();
        }

        protected void gvRenda_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvRenda.PageIndex = e.NewPageIndex;
            ListaRenda();
        }

        protected void Editar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GridViewRow row = (GridViewRow)button.NamingContainer;

            int rowIndex = row.RowIndex;

            Label idRenda = (Label)row.FindControl("IdRenda");
            Label txbValorRenda = (Label)row.FindControl("lblValorRenda");
            Label ddlTipoRenda = (Label)row.FindControl("lblTipoRenda");
            Label txtDataEntrada = (Label)row.FindControl("lblDataEntrada");

            string valorRenda = Regex.Replace(txbValorRenda.Text, @"R\$|\s|,00", "");
            string tipoRenda = ddlTipoRenda.Text;
            string dataEntrada = txtDataEntrada.Text;
 
            ExibirformularioEdit( valorRenda, tipoRenda, dataEntrada);
        }

        protected void Excluir_Click(object sender, EventArgs e)
        {

        }

        protected void btnSalvarEdit_Click(object sender, EventArgs e)
        {
            var renda = new Entidades.Models.Renda
            {
                IdRenda = 1,
                dblValorRenda = txbValorRenda.Text != "" ? Convert.ToDouble(txbValorRenda.Text) : 0,
                txtTipoRenda = ddlTipoRenda.Text != "" ? ddlTipoRenda.Text : "Outros",
                dteDataEntrada = Convert.ToDateTime(txtDataEntrada.Text)
            };
            new RendaBusiness(new RendaRepository()).UpdateRenda(renda);
            ExibirLista();
        }
    }
}