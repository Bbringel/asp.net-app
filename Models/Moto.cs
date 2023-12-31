using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMoto.Models;

public class Moto
{
    public int Id { get; set; }

    [StringLength(30, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [StringLength(10, MinimumLength = 3)]
    [Required]
    public string? Circuit { get; set; }

    [StringLength(10, MinimumLength = 3)]
    [Required]
    public string? Team { get; set; }

    [Display(Name = "World Rank")]
    public decimal WorldRank { get; set; }

    [Display(Name = "Driver Number")]
    public string? DriverNumber { get; set; }
}

