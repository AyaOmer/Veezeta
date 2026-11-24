using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Veezeta_Domain.Enums;

namespace Veezeta_Domain.Models
{
    public class DoctorSchedule
    {
        public int Id { get; set; }
        public string DoctorId { get; set; } = null!;
        public int ClinicId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        [Range(0, 480)]
        public int SlotDurationMinutes { get; set; } = 30;
        public DateOnly? EffectiveFrom { get; set; }

        public DateOnly? EffectiveTo { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties

        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; } = null!;

        [ForeignKey(nameof(ClinicId))]
        public Clinic Clinic { get; set; } = null!;
    }
}
