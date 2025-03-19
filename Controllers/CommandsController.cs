using dotnet_Api.Dtos;
using dotnetapi.data;
using dotnetapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
           
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);
            
            if (command == null) 
            {
                return NotFound(); 
            }

            return Ok(command);
        }

       [HttpPost]
       public ActionResult<CommandDto> CreateCommand([FromBody] CommandDto commandDto)
       {
         if (commandDto == null) return BadRequest();

          var newCommand = _repository.CreateCommand(commandDto);

          return Ok(newCommand);
       }
       
     }
}
