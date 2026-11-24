using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veezeta_Domain.Models.IdentityModels;
using Veezeta_Services.Interface;

namespace VEEZETA.Controllers.Patient
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IAuthService authService;

        public RegistrationController(IAuthService authService)
        {
            this.authService = authService;
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res=await authService.register(model);
            if(res.IsAuthenticated!=true)
                return BadRequest(res.Message);

            return Ok(res);
        }
    }
}
