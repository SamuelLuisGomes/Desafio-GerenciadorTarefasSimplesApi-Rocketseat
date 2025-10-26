using System.Net;

namespace GerenciadorTarefasSimples.Exceptions.ExceptionBase
{
    public abstract class TasksException : SystemException
    {
        public TasksException(string errorMessage): base(errorMessage)
        { 
        
        }

        public abstract List<string> GetErrors();
        public abstract HttpStatusCode GetHttpStatusCode();
    }
}
