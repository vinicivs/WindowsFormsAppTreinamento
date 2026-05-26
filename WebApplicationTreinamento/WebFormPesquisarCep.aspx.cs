using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBus;
using ClassLibraryMd;

namespace WebApplicationTreinamento
{
    public partial class WebFormPesquisarCep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listarcep = BusClass.Listagem();

            gvwDados.DataSource = listarcep;
            gvwDados.DataBind();
        }

        protected void lbnVoltar_Click(object sender, EventArgs e)
        {

            // Redirecionar para a inicial - página específica
            Response.Redirect("~/Default.aspx");

            // Redirecionar para a página que chamou
            //if (Request.UrlReferrer != null)
                //Response.Redirect(Request.UrlReferrer.ToString());
            //else // Se não houver uma página de referência, redirecionar para a página inicial
                //Response.Redirect("~/Default.aspx"); // fallback
        
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de CEP está vazio
            if (txtCep.Text == "")
            {
                // Exibir mensagem de alerta para o usuário
                ScriptManager.RegisterStartupScript(
                    this,
                    GetType(),
                    "msg",
                    $"alert('Informe o Cep!');",
                    true
                );
                txtCep.Focus();
                return;
            }

            //Pesquisar Cep
            var pesquisarcep = BusClass.Localizar(txtCep.Text);

            // Verificar se o cep foi encontrado
            if (pesquisarcep.Id == 0)
            {
                // Exibir mensagem de alerta para o usuário
                ScriptManager.RegisterStartupScript(
                    this,
                    GetType(),
                    "msg",
                    $"alert('Cep não encontrado!');",
                    true
                );
                txtCep.Focus();
                return;
            }

            gvwDados.DataSource = new List<MdClass> { pesquisarcep };
            gvwDados.DataBind();
        }
    }
}