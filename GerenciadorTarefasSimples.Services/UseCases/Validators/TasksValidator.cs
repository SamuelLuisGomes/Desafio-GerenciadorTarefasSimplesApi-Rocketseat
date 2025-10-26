using FluentValidation;
using GerenciadorTarefasSimples.Controllers.Requests;

namespace GerenciadorTarefasSimples.Controllers.Validators
{
    public class TasksValidator : AbstractValidator<TasksJson>
    {
        public TasksValidator()
        {
            RuleFor(task => task.Name)
                .NotEmpty().WithMessage("O Nome é obrigatório")
                .MaximumLength(100).WithMessage("O nome deve ter no máximo 100 caracteres");

            RuleFor(task => task.Description)
                .MaximumLength(500).WithMessage("A descrição deve ter no máximo 500 caracteres");

            RuleFor(task => task.Priority)
                .NotEmpty().WithMessage("A Prioridade é obrigatória")
                .IsInEnum().WithMessage("O valor não corresponde a uma prioridade");

            RuleFor(task => task.DueDate)
                .NotEmpty().WithMessage("A Data é obrigatória")
                .GreaterThanOrEqualTo(DateTime.Today.AddDays(1)).WithMessage("A data tem que estar no futuro");

            RuleFor(task => task.Status)
                .NotEmpty().WithMessage("O status é obrigatório")
                .IsInEnum().WithMessage("O valor não corresponde a um status");
        }
    }
}
