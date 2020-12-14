using System;
using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Services
{
    public interface ICommandService
    {
        IEnumerable<CommandModel> GetCommands();

        CommandModel GetCommand(Guid id);
        CommandModel CreateCommand(CommandModel commandModel);
    }
}