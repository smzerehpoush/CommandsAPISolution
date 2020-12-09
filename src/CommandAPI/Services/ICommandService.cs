using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Services
{
    public interface ICommandService
    {
        IEnumerable<CommandModel> GetCommands();
    }
}