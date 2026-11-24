using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Veezeta_Domain.Enums;

namespace Veezeta_Domain.Models
{
    [Index(nameof(Code), IsUnique = true)]
    public class Coupon
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Code { get; set; } = null!;
        [MaxLength(500)]
        public string? Description { get; set; }

        [Precision(18, 2)]
        public decimal Value { get; set; }
        public DiscountType DiscountType { get; set; }

        public int? MaxUses { get; set; }

        public int UsedCount { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<CouponRedemption> Redemptions { get; set; }
            = new List<CouponRedemption>();
    }
}
