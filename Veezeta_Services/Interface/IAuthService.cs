using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta_Domain.Models.IdentityModels;

namespace Veezeta_Services.Interface
{
    public interface IAuthService
    {
        Task<AuthModel> register(RegisterModel model);
    }
}
