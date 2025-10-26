using System.Net;

namespace GerenciadorTarefasSimples.Exceptions.ExceptionBase
{
    public class NotFoundException : TasksException
    {
        public NotFoundException(string errorMessage) : base(errorMessage)
        {
        }

        public override List<string> GetErrors() => [Message];

        public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.NotFound;
    }
}
