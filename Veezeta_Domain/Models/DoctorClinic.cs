using System.ComponentModel.DataAnnotations.Schema;

namespace Veezeta_Domain.Models
{
    public class DoctorClinic
    {
        public string DoctorId { get; set; }
        public int ClinicId { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
        // Navigation Properties
        [ForeignKey(nameof(DoctorId))]

        public Doctor Doctor { get; set; } = null!;
        [ForeignKey(nameof(ClinicId))]

        public Clinic Clinic { get; set; } = null!;
    }
}
