using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProSales.Domain.Dtos
{
    public class RetornoDto
    {
        public string Message { get; set; } = "Erro ao realizar ação";
        public bool Success { get; set; } = false;
        public int StatusCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? TotalItems { get; set; } = 0;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Page { get; set; } = "0";
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Object Data { get; set; }
        

        public static RetornoDto objectDuplicaded(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Item já cadastrado";
            ret.Success = false;
            ret.StatusCode = StatusCodes.Status409Conflict;
            ret.TotalItems = 1;
            ret.Page = "1/1";

            ret.Data = obj;
            return ret;
        }

        public static RetornoDto objectGenericError(Object err){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Erro ao tentar realizar ação";
            ret.Success = false;
            ret.StatusCode = StatusCodes.Status500InternalServerError;
            ret.Data = err;

            ret.TotalItems = null;
            ret.Page = null;
            return ret;
        }


        public static RetornoDto objectNotFound(string message = ""){
            RetornoDto ret = new RetornoDto();
            ret.Message = message == "" ? "Item não encontrado" : message;
            ret.Success = false;
            ret.StatusCode = StatusCodes.Status404NotFound;

            ret.TotalItems = null;
            ret.Page = null;
            ret.Data = null;
            return ret;
        }

        public static RetornoDto unauthorized(string message = ""){
            RetornoDto ret = new RetornoDto();
            ret.Message = message == "" ? "Sem permissão para realziar esta ação" : message;
            ret.Success = false;
            ret.StatusCode = StatusCodes.Status401Unauthorized;

            ret.TotalItems = null;
            ret.Page = null;
            ret.Data = null;
            return ret;
        }

        public static RetornoDto objectCreateSuccess(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Criado com sucesso";
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status201Created;
            ret.TotalItems = null;
            ret.Page = null;

            ret.Data = obj;
            return ret;
        }

        public static RetornoDto objectUpdateSuccess(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Atualizado com sucesso";
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status201Created;
            ret.TotalItems = null;
            ret.Page = null;

            ret.Data = obj;
            return ret;
        }

        public static RetornoDto objectDeletedSuccess(string message = ""){
            RetornoDto ret = new RetornoDto();
            ret.Message = message == "" ? "Deletado com sucesso" : message;
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status200OK;
            ret.TotalItems = null;
            ret.Page = null;

            return ret;
        }

        public static RetornoDto objectFoundSuccess(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Localizado com sucesso";
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status200OK;
            ret.TotalItems = 1;
            ret.Page = "1/1";

            ret.Data = obj;
            return ret;
        }

        public static RetornoDto objectsFoundSuccess(Object values, int skip, int take, long totalItems){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Localizado com sucesso";
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status200OK;

            ret.TotalItems = totalItems;

            var actualPage = skip +1;
            var totalPages = (totalItems/take);
            var labelPage = actualPage > totalPages ? 0 : actualPage;

            ret.Page = (actualPage == 1 && labelPage == 0) ? "1/1" : $"{labelPage}/{totalPages}";

            Console.WriteLine(totalPages);

            ret.Data = values;
            return ret;
        }
    }
}