using System.ComponentModel.DataAnnotations;

namespace WebApp
{
    public class AppSettings
    {
        [Required]
        public string MapTilerApiKey { get; set; }
    }
}
