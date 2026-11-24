using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veezeta_Domain.Models
{
    public class PatientInsurance
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public int InsuranceProviderId { get; set; }

        public DateOnly ExpiryDate { get; set; }

        [MaxLength(1000)]
        public string? MedicalCardPhoto { get; set; }

        public bool IsVerified { get; set; }

        public DateTime? VerifiedAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public InsuranceProvider InsuranceProvider { get; set; } = null!;

        public ICollection<AppointmentInsurance> AppointmentInsurances { get; set; }
            = new List<AppointmentInsurance>();
    }



}