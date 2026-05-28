using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using WebApplicationAPITreinamento.Models;

namespace WebApplicationAPITreinamento.Helpers
{
    public static class ApiResponseFactory
    {
        // Método para criar uma resposta de sucesso
        public static IHttpActionResult Sucesso(ApiController controller, object dados = null, string mensagem = null)
        {
            var response = ApiResponse.Ok(dados, mensagem);
            return new OkNegotiatedContentResult<ApiResponse>(response, controller);
        }
        // Método para criar uma resposta de sucesso criado
        public static IHttpActionResult Criado(ApiController controller, object dados = null, string mensagem = null, int status = 201, string detalhe = null)
        {
            var response = ApiResponse.Criado(mensagem, detalhe);
            var statusCode = (HttpStatusCode)status;
            return new NegotiatedContentResult<ApiResponse>(statusCode, response, controller);
        }
        // Método para criar uma resposta de erro
        public static IHttpActionResult Erro(ApiController controller, string mensagem, int status = 400, string detalhe = null)
        {
            var response = ApiResponse.Falha(mensagem, detalhe);
            var statusCode = (HttpStatusCode)status;
            return new NegotiatedContentResult<ApiResponse>(statusCode, response, controller);
        }
    }
}