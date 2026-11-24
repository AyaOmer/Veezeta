using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Veezeta_Domain.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class InsuranceProvider
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;
        [Url]
        [MaxLength(500)]
        public string? Website { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        //Navigation Property 
        public ICollection<PatientInsurance> PatientInsurances { get; set; }
            = new List<PatientInsurance>();


    }
}
