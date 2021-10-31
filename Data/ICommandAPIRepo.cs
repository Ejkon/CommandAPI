using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data 
{
    public interface ICommandAPIRepo
    {
        // Our Repository should provide SaveChanges method; will revisit when doing EF Core
        bool SaveChanges();

        // All other method signatures that consumers of this interface can use
        // to obtatin and manipulate data.
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}