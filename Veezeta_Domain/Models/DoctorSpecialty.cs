using System.ComponentModel.DataAnnotations.Schema;

namespace Veezeta_Domain.Models
{
    public class DoctorSpecialty
    {
        public string DoctorId { get; set; } = null!;
        public int SpecialtyId { get; set; }
        // Navigation Properties
        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; } = null!;

        [ForeignKey(nameof(SpecialtyId))]
        public Specialty Specialty { get; set; } = null!;
    }
}
