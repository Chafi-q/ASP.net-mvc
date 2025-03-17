using Commander.Data;
using dotnetapi.data;
using dotnetapi.Models;

namespace dotnet_Api.Data {
    public class CommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext  _context ;
        public CommanderRepo(CommanderContext context)
        {
            _context = context ;
               
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            throw new NotImplementedException();
        }
    }
}