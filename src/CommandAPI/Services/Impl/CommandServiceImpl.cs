using System;
using System.Collections.Generic;
using System.Linq;
using CommandAPI.Context;
using CommandAPI.Models;

namespace CommandAPI.Services.Impl
{
    public class CommandServiceImpl : ICommandService
    {
        private readonly CommandContext _commandContext;

        public CommandServiceImpl(CommandContext commandContext)
        {
            _commandContext = commandContext;
        }

        public IEnumerable<CommandModel> GetCommands()
        {
            return _commandContext.Commands.ToList();
        }

        public CommandModel GetCommand(Guid id)
        {
            Console.WriteLine($"Trying to find Command with Id : {id}");
            return _commandContext.Commands.FirstOrDefault(p=> p.Id == id);
        }

        public CommandModel CreateCommand(CommandModel commandModel)
        {
            throw new NotImplementedException();
        }
    }
}