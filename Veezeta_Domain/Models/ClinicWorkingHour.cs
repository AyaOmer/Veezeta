using System.ComponentModel.DataAnnotations.Schema;

namespace Veezeta_Domain.Models
{
    public class ClinicWorkingHour
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        public TimeOnly OpenTime { get; set; }

        public TimeOnly CloseTime { get; set; }

        public bool IsClosed { get; set; }
        // Navigation Properties
        [ForeignKey(nameof(ClinicId))]
        public Clinic Clinic { get; set; } = null!;

    }
}

