
using dotnetapi.data;
using dotnetapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.Data {

    public class MockCommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var Commands = new List <Command> {
                new Command {Id=1, Title= "Milk" , Content="Commandé après des heures "},
                new Command {Id=2, Title= "Cofee" , Content="Commandé le jour "},
                new Command {Id=3, Title= "Bread" , Content="Commandé sur place"}
            };
            
            return Commands;
        }

        public Command GetCommandById(int id)
        {
            var command =  new Command {Id=1, Title= "Milk" , Content="Commandé après des heures "};

            return command ;
        }
    }

}
