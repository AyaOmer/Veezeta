using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta_Domain.Models;

namespace Veezeta_Domain.DTO
{
    public class AppoinmentDTO
    {
        public DayOfWeek day { get; set; }
        public List<TimeSlotDTO> TimeSlots { get; set; }
    }
}
