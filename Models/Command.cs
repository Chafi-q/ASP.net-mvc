using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapi.Models {

     [Table("Commands")]
     public class Command {
        
        [Key]
        public int Id {get ; set ;}
        
        [Required]
        [MaxLength(250)]
        public  string Title {get ; set ;}
        [Required]
         public  string Content {get; set ;}


     }

}