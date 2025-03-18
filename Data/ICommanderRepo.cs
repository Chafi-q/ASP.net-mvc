using dotnet_Api.Dtos;
using dotnetapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.data {
    public interface ICommanderRepo {
        IEnumerable<Command> GetAllCommands () ;
        CommandDto GetCommandById(int id);

        void CreateCommand(CommandDto commandDto);

    }
} 