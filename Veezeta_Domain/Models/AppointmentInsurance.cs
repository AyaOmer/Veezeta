using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Veezeta_Domain.Models
{




    [Index(nameof(AppointmentId), IsUnique = true)]
    public class    AppointmentInsurance
    {
        public int Id { get; set; }

        public int AppointmentId { get; set; }

        public int PatientInsuranceId { get; set; }

        [Precision(18, 2)]
        public decimal CoverageAmount { get; set; }

        [Precision(18, 2)]
        public decimal PatientCopayment { get; set; }

        [MaxLength(100)]
        public string? AuthorizationNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties

        public Appointment Appointment { get; set; } = null!;

        public PatientInsurance PatientInsurance { get; set; } = null!;
    }
}