using GerenciadorTarefasSimples.Controllers.Requests;
using GerenciadorTarefasSimples.Controllers.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefasSimples.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseAllTaskJson>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(TaksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] TaksJson request)
        {
            return Created();
        }
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public IActionResult Update([FromRoute] int id, [FromBody] TaksJson request)
        {
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public IActionResult Delete([FromRoute] int id)
        {
            return NoContent();
        }
    }
}
