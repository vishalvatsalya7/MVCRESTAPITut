using PlatformDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//48.25
namespace PlatformDemo.Data
{
    public class CommandInfo : ICommandInfo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { CmdName = "Boil an egg", Id = 0, Description = "Eats egg", Platform = "Kitchen" };
        }

        public IEnumerable<Command> GetCommands()
        {
            var commands = new List<Command>()
            {
                new Command { CmdName = "Boil an egg", Id = 0, Description = "Eats egg", Platform = "Kitchen" },
                new Command { CmdName = "Boil an fruit", Id = 1, Description = "Eats fruit", Platform = "Kitchen" },
                new Command { CmdName = "Boil an apple", Id = 2, Description = "Eats apple", Platform = "Kitchen" }
            };
            return commands;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
