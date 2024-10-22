using System.ComponentModel.DataAnnotations;

namespace TabiSaki.WebApp;

public class AppSettings
{
    [Required]
    public required string MapTilerApiKey { get; init; }

}