using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta_Domain.Enums;
using Veezeta_Domain.Models;

namespace Veezeta_Domain.DTO
{
    public class DoctorDTO
    {
        public string FullName { get; set; }
        public byte[]? Image { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Gender gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Specialize { get; set; }
        public float Price { get; set; }
        public List<AppoinmentDTO> Appoinments { get; set; }

    }
}
