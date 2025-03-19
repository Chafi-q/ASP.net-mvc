using dotnetapi.Models;

namespace dotnet_Api.Dtos {
   
   public class CommandMapper {
      public static CommandDto ToDto(Command command){
       
        return new  CommandDto {
            Id = command.Id ,
            Title = command.Title

        };
      }

      public static Command ToModel(CommandDto dto){
       
        return new  Command {
            Title = dto.Title,
            Content = "null"
        };
      }

   }



}