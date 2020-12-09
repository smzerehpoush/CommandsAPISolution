using System;
using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models
{
    public class CommandModel
    {
        [Key] [Required] public Guid Id { get; set; }

        [Required] [MaxLength(250)] public string HowTo { get; set; }

        [Required] public string Platform { get; set; }

        [Required] public string CommandLine { get; set; }

        public CommandModel(string howTo, string platform, string commandLine)
        {
            Id = Guid.NewGuid();
            HowTo = howTo;
            Platform = platform;
            CommandLine = commandLine;
        }
    }
}