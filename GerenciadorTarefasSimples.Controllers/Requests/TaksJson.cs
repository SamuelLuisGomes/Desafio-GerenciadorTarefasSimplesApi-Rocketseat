using GerenciadorTarefasSimples.Controllers.Enums;

namespace GerenciadorTarefasSimples.Controllers.Requests
{
    public class TaksJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; } 
    }
}
