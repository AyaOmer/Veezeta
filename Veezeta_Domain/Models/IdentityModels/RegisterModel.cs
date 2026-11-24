using Veezeta_Domain.Enums;

namespace Veezeta_Domain.Models.IdentityModels
{
    public class RegisterModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public string PhoneNumber { get; set; }
        public Gender gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
