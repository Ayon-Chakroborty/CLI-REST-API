using System.ComponentModel.DataAnnotations;

namespace DOTNET_REST_API.DTOs
{
    public class CommandReadDto
    {

        public int Id { get; set; }

        public string HowTo { get; set; }
        
        public string LineSnippet { get; set; }
        
        // Don't need this on Client side
        // public string Platform { get; set; }

    }
}