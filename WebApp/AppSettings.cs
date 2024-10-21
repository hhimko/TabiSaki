using System.ComponentModel.DataAnnotations;

namespace WebApp
{
    public class AppSettings
    {
        [Required]
        public required string MapTilerApiKey { get; set; }
    }
}
