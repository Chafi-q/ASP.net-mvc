using System.ComponentModel.DataAnnotations;

namespace dotnetapi.Models {
     public class Command {
        
        [Key]
        public int Id {get ; set ;}
        
        [Required]
        public  string Title {get ; set ;}
        [Required]
         public  string Content {get; set ;}


     }

}