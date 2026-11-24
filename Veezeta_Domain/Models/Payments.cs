using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Veezeta_Domain.Enums;

namespace Veezeta_Domain.Models
{



    [Index(nameof(TransactionId), IsUnique = true)]
    public class Payment
    {
        public int Id { get; set; }

        public int AppointmentId { get; set; }

        [MaxLength(150)]
        public string? TransactionId { get; set; }

        [MaxLength(50)]
        public PaymentGateway PaymentGateway { get; set; }

        [Precision(18, 2)]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(3)]
        public string Currency { get; set; } = "EGP";

        [Required]
     
        public PaymentMethod PaymentMethod { get; set; } 

        // Pending, Succeeded, Failed, Refunded

        [Required]
        [MaxLength(30)]
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

        [MaxLength(1000)]
        public string? FailureReason { get; set; }

        public DateTime? PaidAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Appointment Appointment { get; set; } = null!;
    }

}
