using GerenciadorTarefasSimples.Controllers.Requests;
using GerenciadorTarefasSimples.Controllers.Responses;

namespace GerenciadorTarefasSimples.Services.UseCases.Tasks
{
    public interface ITasksRepository
    {
        public ResponseAllTaskJson GetAll();
        public TasksJson GetById(Guid id);
        public void Create(TasksJson task);
        public void Update(Guid id, TasksJson task);
        public void Delete(Guid id);
    }
}
