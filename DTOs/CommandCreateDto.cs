using System.ComponentModel.DataAnnotations;

namespace DOTNET_REST_API.DTOs
{
    public class CommandCreateDto
    {
        // DB will create ID, not needed on client side
        // public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string LineSnippet { get; set; }
    
        [Required]
        public string Platform { get; set; }

    }
}