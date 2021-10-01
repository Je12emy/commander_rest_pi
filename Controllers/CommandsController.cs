using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using net_rest.Data;
using net_rest.Models;

namespace net_rest
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository){
            _repository = repository;
        }

        // GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = this._repository.GetAllCommands();
            return Ok(commandItems);
        }

        // GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = this._repository.GetCommandById(id);
            return Ok(command);
        }
    }
}

