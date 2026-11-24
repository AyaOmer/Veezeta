using System.ComponentModel.DataAnnotations;

namespace Veezeta_Domain.Models
{
    public class Specialty
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(200)]
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        // Navigation Properties
        public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; }
     = new List<DoctorSpecialty>();
    }
}
