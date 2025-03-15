using dotnetapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.data {
    public interface ICommanderRepo {
        IEnumerable<Command> GetAllCommands () ;
        Command GetCommandById(int id);

    }
} 