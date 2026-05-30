using ClassLibraryBus;
using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCTreinamento.Models;

namespace WebApplicationMVCTreinamento.Controllers
{
    public class CepController : Controller
    {
        // GET: Cep
        public ActionResult Index()
        {
            // Retorna a lista de CEPs cadastrados
            List<Ceps> lista = new List<Ceps>();

            // Retorna a lista de CEPs cadastrados
            var listagem = BusClass.Listagem();

            // Mapeia os dados do modelo de negócio para o modelo de exibição (ViewModel)
            lista = listagem.Select(x => new Ceps
            {
                Id = x.Id,
                Cep = x.Cep,
                Logradouro = x.Logradouro,
                Numero = x.Numero,
                Complemento = x.Complemento,
                Bairro = x.Bairro,
                Cidade = x.Cidade,
                Uf = x.Uf
            }).ToList();

            // Retorna a lista de CEPs para a view
            return View(lista);
        }

        // CREATE GET
        public ActionResult Create()
        {
            // Retorna a view para criar um novo Cep
            return View();
        }

        // CREATE POST
        [HttpPost]
        public ActionResult Create(Ceps c)
        {
            // Cadastra um novo Cep
            BusClass.Inserir(new MdClass
            {
                Cep = c.Cep,
                Logradouro = c.Logradouro,
                Numero = c.Numero,
                Complemento = c.Complemento,
                Bairro = c.Bairro,
                Cidade = c.Cidade,
                Uf = c.Uf
            });
            // Após cadastrar o Cep, redireciona para a página de listagem (Index)
            return RedirectToAction("Index");
        }

        // EDIT GET
        public ActionResult Edit(int id)
        {
            
            Ceps c = new Ceps();
            // Localiza o Cep pelo ID
            var pesquisarcep = BusClass.Localizar(id);

            // Mapeia os dados do modelo de negócio para o modelo de exibição (ViewModel)
            c.Id = pesquisarcep.Id;
            c.Cep = pesquisarcep.Cep;
            c.Logradouro = pesquisarcep.Logradouro;
            c.Numero = pesquisarcep.Numero;
            c.Complemento = pesquisarcep.Complemento;
            c.Bairro = pesquisarcep.Bairro;
            c.Cidade = pesquisarcep.Cidade;
            c.Uf = pesquisarcep.Uf;
            // Retorna o Cep encontrado para a view de edição
            return View(c);
        }

        // EDIT POST
        [HttpPost]
        public ActionResult Edit(Ceps c)
        {
            // Atualiza o Cep pelo ID
            BusClass.Alterar(new MdClass
            {
                Id = c.Id,
                Cep = c.Cep,
                Logradouro = c.Logradouro,
                Numero = c.Numero,
                Complemento = c.Complemento,
                Bairro = c.Bairro,
                Cidade = c.Cidade,
                Uf = c.Uf
            });

            return RedirectToAction("Index");
        }

        // DELETE GET
        public ActionResult Delete(int id)
        {
            Ceps c = new Ceps();
            // Localiza o Cep pelo ID
            var pesquisarcep = BusClass.Localizar(id);

            // Mapeia os dados do modelo de negócio para o modelo de exibição (ViewModel)
            c.Id = pesquisarcep.Id;
            c.Cep = pesquisarcep.Cep;
            c.Logradouro = pesquisarcep.Logradouro;
            c.Numero = pesquisarcep.Numero;
            c.Complemento = pesquisarcep.Complemento;
            c.Bairro = pesquisarcep.Bairro;
            c.Cidade = pesquisarcep.Cidade;
            c.Uf = pesquisarcep.Uf;
            // Retorna o Cep encontrado para a view de edição

            return View(c);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            // Exclui o Cep pelo ID
            BusClass.Apagar(new MdClass { Id = id });
           
            return RedirectToAction("Index");
        }
    }
}