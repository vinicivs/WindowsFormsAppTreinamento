using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBus;

namespace WebApplicationTreinamento
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Campos obrigatórios: Cep, Logradouro, Numero, Bairro, Cidade e Uf
            if (string.IsNullOrEmpty(txtCep.Text) ||
                string.IsNullOrEmpty(txtLogradouro.Text) ||
                string.IsNullOrEmpty(txtBairro.Text) ||
                string.IsNullOrEmpty(txtCidade.Text) ||
                string.IsNullOrEmpty(txtUF.Text))
            {
                // Exibir uma mensagem de erro ou realizar alguma ação para informar o usuário sobre os campos obrigatórios
                //lblMensagem.Text = "Por favor, preencha todos os campos obrigatórios.";
                // Exibir mensagem de alerta para o usuário
                ScriptManager.RegisterStartupScript(
                    this,
                    GetType(),
                    "msg",
                    $"alert('Informe todos os campos obrigatórios!');",
                    true
                );
                txtCep.Focus(); // Definir o foco no campo de CEP para facilitar a correção
                return;
            }

            // Criar um objeto da classe de modelo (MdClass) e preencher suas propriedades com os valores dos campos de entrada
            BusClass.Inserir(new ClassLibraryMd.MdClass
            {
                Cep = txtCep.Text,
                Logradouro = txtLogradouro.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Uf = txtUF.Text
            });

            // Exibir mensagem de alerta para o usuário de cadastro concluído com sucesso
            ScriptManager.RegisterStartupScript(
                this,
                GetType(),
                "msg",
                $"alert('Cadastro feito com sucesso!');",
                true
            );


        }
    }
}