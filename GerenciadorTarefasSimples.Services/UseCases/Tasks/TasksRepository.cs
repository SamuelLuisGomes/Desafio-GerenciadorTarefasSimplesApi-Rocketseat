using System.Reflection.Metadata.Ecma335;
using GerenciadorTarefasSimples.Controllers.Requests;
using GerenciadorTarefasSimples.Controllers.Responses;
using GerenciadorTarefasSimples.Controllers.Validators;
using GerenciadorTarefasSimples.Exceptions.ExceptionBase;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefasSimples.Services.UseCases.Tasks
{
    public class TasksRepository : ITasksRepository
    {
        private readonly List<TasksJson> _tasks = [];

        public void Create(TasksJson task)
        {
            Validade(task);

            _tasks.Add(new TasksJson
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                Priority = task.Priority,
                DueDate = task.DueDate,
                Status = task.Status,
            });
        }

        public void Delete(Guid id)
        {
            var item = _tasks.FirstOrDefault(i => i.Id == id);
            if (item is null)
                throw new NotFoundException("Tarefa não encontrada!");

            _tasks.Remove(item);
        }

        public ResponseAllTaskJson GetAll()
        {
            var response = new ResponseAllTaskJson
            {
                Tasks = _tasks
            };

            return response;
        }

        public TasksJson GetById(Guid id)
        {
            var item = _tasks.FirstOrDefault(i => i.Id == id);
            if (item is null)
                throw new NotFoundException("Tarefa não encontrada");

            return item;
        }

        public void Update(Guid id, TasksJson task)
        {
            Validade(task);

            var item = _tasks.FirstOrDefault(i => i.Id == id);

            if (item is null)
                throw new NotFoundException("Tarefa não encontrada!");

            item.Name = task.Name;
            item.Description = task.Description;
            item.Priority = task.Priority;
            item.DueDate = task.DueDate;
            item.Status = task.Status;
        }

        private void Validade(TasksJson task)
        {
            var validator = new TasksValidator();
            var resultado = validator.Validate(task);

            if (resultado.IsValid == false)
            {
                var errors = resultado.Errors.Select(faiture => faiture.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errors);
            }
        }
    }
}
