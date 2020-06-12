using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Apologizes, this name is too long")]
    public string Name { get; set; }

    [Required]
    [StringLength(255)]
    public string Species { get; set; }

    [Required]
    [StringLength(100)]
    public string Family { get; set; }

    [Required]
    [Range(0, 500, ErrorMessage = "Apologies this value has to be between  0 - 500")]
    public int Age { get; set; }

    public string ImgUrl { get; set; }

    [Required]
    public string Gender { get; set; }

    [StringLength(255)]
    public string Mass { get; set; }

    [StringLength(255)]
    public string Diet { get; set; }

    [StringLength(255)]
    public string Period { get; set; }

    [StringLength(255)]
    public string PreferredFood { get; set; }
  }
}