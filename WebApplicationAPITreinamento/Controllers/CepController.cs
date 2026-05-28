using ClassLibraryBus;
using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationAPITreinamento.Helpers;

namespace WebApplicationAPITreinamento.Controllers
{
    public class CepController : ApiController
    {
        [HttpGet]
        public IEnumerable<MdClass> Get()// Retorna a lista de CEPs cadastrados - mais simples sem tratamento de erros
        {
            try
            {
                // Retorna a lista de CEPs cadastrados
                var lista = BusClass.Listagem();
                // Verifica se a lista está vazia e retorna um status code apropriado
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [HttpGet]
        public IHttpActionResult Get(string cep)
        {

            try
            {
                // Retorna a lista de CEPs cadastrados
                var resultado = BusClass.Localizar(cep);

                if (resultado.Id == 0)
                {
                    // Se o CEP não for encontrado, retorna um status code 404 (Not Found)
                    return ApiResponseFactory.Erro(this, "Erro, Cep não localizado", 404);
                }

                // Se o CEP for encontrado, retorna os dados do CEP com um status code 200 (OK)
                return ApiResponseFactory.Sucesso(this, resultado, "Cep encontrado");
            }
            catch (Exception)
            {
                // Em caso de erro, retorna um status code 500 (Internal Server Error)
                return ApiResponseFactory.Erro(this, "Erro, ao pesquisar o Cep", 500);

                throw;
            }
        }

        [HttpPost]
        public IHttpActionResult Post(MdClass cep)
        {
            try
            {
                // Verifica se o objeto recebido é válido
                if (cep == null)
                    // Se o objeto cep for nulo, retorna um status code 400 (Bad Request)
                    return ApiResponseFactory.Erro(this, "Objeto inválido", 400);

                // Tenta inserir o CEP usando a camada de negócios
                var resultado = BusClass.Inserir(cep);

                //Pesquisa o Cep recém-inserido para retornar os dados completos
                var idresultado = BusClass.Localizar(cep.Cep);

                // Retorna o objeto criado com os dados completos
                cep.Id = idresultado.Id;

                // Se a inserção for bem-sucedida, retorna o objeto criado com um status code 201 (Created)
                return ApiResponseFactory.Criado(this, cep, "Cliente criado com sucesso");

            }
            catch (Exception)
            {
                // Em caso de erro, retorna um status code 500 (Internal Server Error)
                return ApiResponseFactory.Erro(this, "Erro ao inserir");

                throw;
            }
            
        }

        [HttpPut]
        public IHttpActionResult Put(MdClass cep)
        {
            try
            {
                // Altera o CEP para verificar se existe
                var resultado = BusClass.Alterar(cep);

                // Se não lozalizar o Cep
                if (resultado != 1)
                {
                    // Se o CEP não for encontrado, retorna um status code 404 (Not Found)
                    return ApiResponseFactory.Erro(this, "Erro, Cep não localizado", 404);

                }
                ;
                // Se a atualização for bem-sucedida, retorna um status code 200 (OK)
                return ApiResponseFactory.Sucesso(this, cep, "Cep atualizado com sucesso");

            }
            catch (Exception)
            {
                // Em caso de erro, retorna um status code 500 (Internal Server Error)
                return ApiResponseFactory.Erro(this, "Erro, ao atualizar o Cep", 500);
                throw;
            }
            
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (id == 0)
                    return ApiResponseFactory.Erro(this, "Id inválido");

                // Verificar se o CEP existe antes de tentar deletar
                var resultado = BusClass.Apagar(new MdClass
                {
                    Id = id
                });

                // Verifica se o resultado da exclusão foi bem-sucedido
                var idresultado = BusClass.Localizar(id);

                // Verifica se o CEP foi encontrado e retorna um status code apropriado
                if (idresultado.Id != 0)
                    // Se o CEP não for encontrado, retorna um status code 404 (Not Found)
                    return ApiResponseFactory.Erro(this, "Erro, Cep não removido", 404);
                // Verifica se ele não existe
                if (idresultado.Id == 0 && resultado == 0)
                    // Cep não encontrado, retorna um status code 404 (Not Found)
                    return ApiResponseFactory.Erro(this, "Erro, Cep não existe", 404);

                // Verifica se a lista está vazia e retorna um status code apropriado
                return ApiResponseFactory.Sucesso(this, null, "Cep removido");

            }
            catch (Exception)
            {
                // Em caso de erro, retorna um status code 500 (Internal Server Error)
                return ApiResponseFactory.Erro(this, "Erro, ao tentar remover Cep", 500);
                throw;
            }
            
        }

    }
}
