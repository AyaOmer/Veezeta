using Veezeta_Infrastrucure.DBContext;

namespace Veezeta_Services.Services
{
    public class AdminServices

    {
        private readonly AppDBContext context;

        public AdminServices(AppDBContext _context)
        {
            context = _context;
        }
        //public bool DeactivateDiscount(int discountID)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<DoctorDTO> GetALLDoctorSearch(int page, int pageSize, string Search)
        //{
        //    page = Math.Max(1, page);
        //    pageSize = Math.Max(1, pageSize);
        //    Search = Search.ToLower().Trim();
        //    var query = context.Doctors.ToList();
        //    if (Search != null)
        //    {
        //        query= (List<Doctor>)query.Where(d => d.user.FullName.ToLower().Contains(Search) ||
        //        d.Specialization.SpecializationName.ToLower().Contains(Search)||
        //        d.user.Email.ToLower().Contains(Search));
        //    }
        //    var res = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        //    var res2 = res.Select(MappingDocters).ToList();
        //    return res2;
        //}
        //public DoctorDTO MappingDocters(Doctor doctor)
        //{
        //    return new DoctorDTO
        //    {
        //        FullName = doctor.user.FullName,
        //        Email = doctor.user.Email,
        //        PhoneNumber = doctor.user.PhoneNumber,
        //        gender = doctor.user.gender,
        //        DateOfBirth = doctor.user.DateOfBirth,
        //        Specialize = doctor.Specialization.SpecializationName,
        //        Price = doctor.Price,
        //        Appoinments = doctor.Appointments.Select(MappingAppoinment).ToList()


        //    };
        //}
        //public AppoinmentDTO MappingAppoinment(Appointment appoinment)
        //{
        //    return new AppoinmentDTO
        //    {
        //        day = appoinment.day,
        //        TimeSlots = appoinment.TimeSlots.Select(t => new TimeSlotDTO { Id = t.Id, Time = t.Time }).ToList()

        //    };
        //}

        //public int NumOfDoctors()
        //{
        //    return context.Doctors.ToList().Count;
        //}

        //public int NumOfPatients()
        //{
        //    return context.Users.Where(d=>d.userType== UserType.Patient).ToList().Count;

        //}

        //public List<int> NumOfRequests()
        //{
        //    int reqCount = context.Bookings.ToList().Count;

        //    int Pending = context.Bookings.Where(s => s.Status == RequestStatus.Pending).ToList().Count;
        //    int Completed = context.Bookings.Where(s => s.Status == RequestStatus.Completed).ToList().Count;
        //    int Cancelled = context.Bookings.Where(s => s.Status == RequestStatus.Cancelled).ToList().Count;
        //    return new List<int> { reqCount, Pending, Completed, Cancelled };
        //}

        //public List<Doctor> Top10Doctors()
        //{
        //    var booking = context.Bookings.ToList();
        //    var res = booking.Where(s => s.Status == RequestStatus.Completed)
        //        .GroupBy(a => a.TimeSlot.appointment.doctor)
        //        .OrderBy(h=>h.Count())
        //        .Take(10)
        //        .Select(g =>g.Key)
        //        .ToList();
        //    return res;


        //}

        //public List<Specialization> Top5Specializations()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<PatientDTO> GetALLPateientSearch(int page, int pageSize, string Search)
        //{
        //    page = Math.Max(1, page);
        //    pageSize = Math.Max(1, pageSize);
        //    Search = Search.Trim().ToLower();
        //    var query = context.Users.Where(u => u.userType == UserType.Patient &&
        //    (u.FullName.Contains(Search) || u.FullName.Contains(Search)));
        //    var result = query.Skip((page-1)*pageSize).Take(pageSize).ToList();
        //    var res = result.Select(MappingPatient);
        //    return res;

        //}
        //public PatientDTO MappingPatient(User user)
        //{
        //    return new PatientDTO
        //    {
        //        FullName=user.FullName,
        //        PhoneNumber=user.PhoneNumber,
        //        DateOfBirth=user.DateOfBirth,
        //        Email=user.Email,
        //        gender= user.gender,
        //        Image=user.Image

        //    };
        //}

    }
}
