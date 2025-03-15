using System.Collections;
using dotnetapi.data;
using dotnetapi.Data;
using dotnetapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.Controllers {
    [Route("api/commands")]
    [ApiController]
    public class CommandsController:ControllerBase {

        private readonly MockCommanderRepo _repository = new() ;


        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands () {
            var CommandItems = _repository.GetAllCommands() ;
            return Ok(CommandItems);
        }



        [HttpGet]
        public ActionResult <Command> GetCommandById(int id) {
            
            var Command = _repository.GetCommandById(id);
            return Ok(Command);

            
        }
        
       

    }

}