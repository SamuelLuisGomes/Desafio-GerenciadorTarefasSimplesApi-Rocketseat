using GerenciadorTarefasSimples.Controllers.Responses;
using GerenciadorTarefasSimples.Exceptions.ExceptionBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GerenciadorTarefasSimples.Services.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
           if(context.Exception is TasksException tasksException)
            {
                context.HttpContext.Response.StatusCode = (int)tasksException.GetHttpStatusCode();

                context.Result = new ObjectResult(new ResponseErrorMessageJson(tasksException.GetErrors()));
            }
            else
            {
                ThrowUnknowError(context);
            }
        }

        private void ThrowUnknowError(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorMessageJson("Erro desconhecido!"));
        }
    }
}
