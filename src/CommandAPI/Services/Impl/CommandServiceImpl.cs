using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Services.Impl
{
    public class CommandServiceImpl : ICommandService
    {
        public IEnumerable<CommandModel> GetCommands()
        {
            return new[] {new CommandModel("fake", "fake platform", "fake cli"),};
        }
    }
}