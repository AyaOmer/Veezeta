using Veezeta_Domain.Models;

namespace Veezeta_Services.Interface
{
    public interface IPatientServices
    {
        Doctor SearchDoctors();

        bool CancelBooking(int BookingId);
    }
}
