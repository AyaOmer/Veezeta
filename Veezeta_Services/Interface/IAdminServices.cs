using Veezeta_Domain.DTO;
using Veezeta_Domain.Models;

namespace Veezeta_Services.Interface
{
    public interface IAdminServices
    {
        int NumOfDoctors();
        int NumOfPatients();
        List<int> NumOfRequests();

        List<Doctor> Top10Doctors();
        bool DeactivateDiscount(int discountID);
        IEnumerable<DoctorDTO> GetALLDoctorSearch(int page, int pageSize, string Search);
        IEnumerable<PatientDTO> GetALLPateientSearch(int page, int pageSize, string Search);


    }
}
