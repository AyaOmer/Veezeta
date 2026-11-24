using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Veezeta_Domain.Enums;

namespace Veezeta_Domain.Models
{
    public class User : IdentityUser
    {

        [Required]
        [MaxLength(100)]

        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]

        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        [MaxLength(100)]
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public string? Image { get; set; }

        public Gender Gender { get; set; }

        public UserType userType { get; set; }
        // Navigation property 
        public Doctor? Doctor { get; set; }

        public ICollection<DoctorClinic> DoctorClinics { get; set; }
    = new List<DoctorClinic>();

        public ICollection<Appointment> PatientAppointments { get; set; }
            = new List<Appointment>();

        public ICollection<PatientInsurance> PatientInsurances { get; set; }
            = new List<PatientInsurance>();

        public ICollection<CouponRedemption> CouponRedemptions { get; set; }
            = new List<CouponRedemption>();



    }
}
