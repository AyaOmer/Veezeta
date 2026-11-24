using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta_Domain.Enums;

namespace Veezeta_Domain.DTO
{
    public class PatientDTO
    {
     public string FullName { get; set; }
    public byte[]? Image { get; set; }

    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Gender gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    

}
}
