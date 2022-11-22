using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProSales.Domain.Dtos
{
    public class RetornoDto
    {
        public string Message { get; set; } = "Erro ao realizar ação";
        public bool Success { get; set; } = false;
        public int StatusCode { get; set; }
        public Object Object { get; set; }

        public static RetornoDto objectDuplicaded(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Item já cadastrado";
            ret.Success = false;
            ret.StatusCode = StatusCodes.Status409Conflict;
            ret.Object = obj;
            return ret;
        }

        public static RetornoDto objectGenericError(Exception err){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Erro ao tentar realizar ação";
            ret.Success = false;
            ret.StatusCode = StatusCodes.Status500InternalServerError;
            ret.Object = err.Message;
            return ret;
        }


        public static RetornoDto objectNotFound(){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Item não encontrado";
            ret.Success = false;
            ret.StatusCode = StatusCodes.Status404NotFound;
            return ret;
        }

        public static RetornoDto objectCreateSuccess(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Criado com sucesso";
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status201Created;
            ret.Object = obj;
            return ret;
        }

        public static RetornoDto objectUpdateSuccess(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Atualizado com sucesso";
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status201Created;
            ret.Object = obj;
            return ret;
        }

        public static RetornoDto objectFoundSuccess(Object obj){
            RetornoDto ret = new RetornoDto();
            ret.Message = "Localizado com sucesso";
            ret.Success = true;
            ret.StatusCode = StatusCodes.Status200OK;
            ret.Object = obj;
            return ret;
        }
    }
}