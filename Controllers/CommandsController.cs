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
            _mapper = mapper;
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
        public ActionResult<CommandDto> CreateCommand(CommandDto commandDto)
        {
            if (commandDto == null)
            {
                return BadRequest("Command data is required.");
            }

            // Map DTO to Command model
            var command = _mapper.Map<Command>(commandDto);

            // Add the command to the database
            _context.Commands.Add(command);
            _context.SaveChanges();  // Synchronous save

            // Return the created Command as DTO
            var createdCommandDto = _mapper.Map<CommandDto>(command);

            // Return the location of the new resource in the response header
            return CreatedAtAction(nameof(GetCommand), new { id = command.Id }, createdCommandDto);
        }
     }
}
