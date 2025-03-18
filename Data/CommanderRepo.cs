using Commander.Data;
using dotnet_Api.Dtos;
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
            var CommandList = _context.Commands.ToList();
            return CommandList ;
        }

        public CommandDto GetCommandById(int id)
        {
           var command = _context.Commands.Find(id);
           return CommandMapper.ToDto(command); 
        }

         public void CreateCommand(CommandDto commandDto)
    {
        var command = CommandMapper.ToModel(commandDto);  
        _context.Commands.Add(command);
        _context.SaveChanges();
    }
}
}