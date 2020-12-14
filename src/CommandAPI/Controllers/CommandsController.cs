using System;
using System.Collections.Generic;
using System.Linq;
using CommandAPI.Models;
using CommandAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandService _commandService;

        public CommandsController(ICommandService commandService)
        {
            _commandService = commandService;
        }

        [HttpGet]
        public ActionResult<CommandModel> Get()
        {
            return Ok(_commandService.GetCommands());
        }

        [HttpGet("{id}")]
        public ActionResult<CommandModel> GetCommandById(Guid id)
        {
            var command = _commandService.GetCommand(id);
            if (command == null)
            {
                return NotFound();
            }

            return Ok(command);
        }
    }
}