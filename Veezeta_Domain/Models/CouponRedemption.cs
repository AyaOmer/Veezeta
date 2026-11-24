using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Veezeta_Domain.Models
{
    [Index(nameof(AppointmentId), IsUnique = true)]
    [Index(nameof(CouponId), nameof(PatientId))]
    public class CouponRedemption
    {
        public int Id { get; set; }

        public int CouponId { get; set; }

        [Required]
        public string PatientId { get; set; } = null!;

        public int AppointmentId { get; set; }

        [Precision(18, 2)]
        public decimal DiscountAmount { get; set; }

        public DateTime RedeemedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties

        public Coupon Coupon { get; set; } = null!;

        [ForeignKey(nameof(PatientId))]
        public User Patient { get; set; } = null!;

        public Appointment Appointment { get; set; } = null!;
    }






}
