using System.ComponentModel.DataAnnotations;

namespace DOTNET_REST_API.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string LineSnippet { get; set; }
        
        [Required]
        public string Platform { get; set; }

    }
}