using GerenciadorTarefasSimples.Controllers.Requests;
using GerenciadorTarefasSimples.Controllers.Responses;
using GerenciadorTarefasSimples.Services.UseCases.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefasSimples.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksRepository _taskRepository;


        public TasksController(ITasksRepository taskRepository) 
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public IActionResult GetAll()
        {
            var tasks = _taskRepository.GetAll();
            if (tasks.Tasks.Count == 0)
                return NotFound();

            return Ok(tasks);
        }
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(TasksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var task = _taskRepository.GetById(id);
            
            return Ok(task);
            
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] TasksJson request)
        {
            _taskRepository.Create(request);
            
            return Created(string.Empty,request);

        }
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status404NotFound)]
        public IActionResult Update([FromRoute] Guid id, [FromBody] TasksJson request)
        {
            _taskRepository.Update(id, request);
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _taskRepository.Delete(id);

            return NoContent();
        }
    }
}
