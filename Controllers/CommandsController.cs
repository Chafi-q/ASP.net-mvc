using dotnetapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.Controllers {
    [Route("api/commands")]
    [ApiController]
    public class CommandsController:ControllerBase {
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands () {
            
        }
       

    }

}