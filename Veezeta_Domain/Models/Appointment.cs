using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Veezeta_Domain.Enums;

namespace Veezeta_Domain.Models
{
    [Index(nameof(DoctorId), nameof(StartAt))]
    [Index(nameof(PatientId), nameof(StartAt))]
    [Index(nameof(ClinicId), nameof(StartAt))]
    public class Appointment
    {
        public int Id { get; set; }
        [Required]
        public string PatientId { get; set; } = null!;

        [Required]
        public string DoctorId { get; set; } = null!;
        public int ClinicId { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }
        [Range(1, 480)]
        public int SlotDurationMinutes { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;
        [Precision(18, 2)]
        public decimal OriginalPrice { get; set; }

        [Precision(18, 2)]
        public decimal DiscountAmount { get; set; }

        [Precision(18, 2)]
        public decimal FinalPrice { get; set; }
        [Required]
        [MaxLength(3)]
        public string Currency { get; set; } = "EGP";

        public DateTime BookedAt { get; set; } = DateTime.UtcNow;

        public DateTime? CancelledAt { get; set; }

        [MaxLength(500)]
        public string? CancellationReason { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
        // SQL Server RowVersion

        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;

        // Navigation Properties

        [ForeignKey(nameof(PatientId))]
        public User Patient { get; set; } = null!;

        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; } = null!;

        [ForeignKey(nameof(ClinicId))]
        public Clinic Clinic { get; set; } = null!;

        public ICollection<Payment> Payments { get; set; }
            = new List<Payment>();

        public CouponRedemption? CouponRedemption { get; set; }

        public AppointmentInsurance? AppointmentInsurance { get; set; }
    }
}