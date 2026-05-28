using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAPITreinamento.Models
{
    public class ApiResponse
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Dados { get; set; }
        public ApiError Erro { get; set; }

        public static ApiResponse Ok(object dados = null, string mensagem = null)
        {
            return new ApiResponse
            {
                Sucesso = true,
                Mensagem = mensagem,
                Dados = dados,
                Erro = null
            };
        }

        public static ApiResponse Criado(object dados = null, string mensagem = null)
        {
            return new ApiResponse
            {
                Sucesso = true,
                Mensagem = mensagem,
                Dados = dados,
                Erro = null
            };
        }

        public static ApiResponse Falha(string mensagem, string detalhe = null)
        {
            return new ApiResponse
            {
                Sucesso = false,
                Mensagem = mensagem,
                Dados = null,
                Erro = new ApiError { Detalhe = detalhe }
            };
        }
    }
}