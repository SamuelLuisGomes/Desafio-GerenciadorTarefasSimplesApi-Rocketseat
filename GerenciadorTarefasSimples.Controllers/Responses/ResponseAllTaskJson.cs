using GerenciadorTarefasSimples.Controllers.Requests;

namespace GerenciadorTarefasSimples.Controllers.Responses
{
    public class ResponseAllTaskJson
    {
        public List<TaksJson> Tasks { get; set; } = [];
    }
}
