using GerenciadorTarefasSimples.Controllers.Requests;

namespace GerenciadorTarefasSimples.Controllers.Responses
{
    public class ResponseAllTaskJson
    {
        public List<TasksJson> Tasks { get; set; } = [];
    }
}
