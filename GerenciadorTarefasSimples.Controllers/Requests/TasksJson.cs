using GerenciadorTarefasSimples.Controllers.Enums;

namespace GerenciadorTarefasSimples.Controllers.Requests
{
    public class TasksJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; } 
    }
}
