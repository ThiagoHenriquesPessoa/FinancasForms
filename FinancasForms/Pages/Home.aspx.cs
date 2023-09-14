using DataAccess.Repository;
using Domain.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinancasForms.Pages
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime primeiroDiaDoMes = new DateTime(dataAtual.Year, dataAtual.Month, 1);
            DateTime ultimoDiaDoMes = new DateTime(dataAtual.Year, dataAtual.Month, DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month));
            txbRendaTotal.Text = new RendaBusiness(new RendaRepository()).GetRendaTotal().ToString("F2");
            txbRendaAnual.Text = new RendaBusiness(new RendaRepository()).GetRendaAnoAtualall().ToString("F2");
            txbRendaMesAtual.Text = new RendaBusiness(new RendaRepository()).GetRendaMesAtualAll().ToString("F2");
            gvRenda.DataSource = new RendaBusiness(new RendaRepository()).GetAllRendaPorData(primeiroDiaDoMes, ultimoDiaDoMes);
            gvRenda.DataBind();
        }
    }
}