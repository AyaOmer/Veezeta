using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Veezeta_Domain.Enums;
using Veezeta_Domain.Helpers;
using Veezeta_Domain.Models;
using Veezeta_Domain.Models.IdentityModels;
using Veezeta_Services.Interface;

namespace Veezeta_Services.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly JWT _jwt;

        public AuthService(UserManager<User> userManager, IOptions<JWT> jwt, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _jwt = jwt.Value;
        }
        public async Task<AuthModel> register(RegisterModel model)
        {
            if (await userManager.FindByEmailAsync(model.Email) is not null)
            {
                return new AuthModel { Message = "Email is already exist" };
            }
            if (await userManager.FindByNameAsync(model.UserName) is not null)
            {
                return new AuthModel { Message = "UserName is already exist" };

            }
            var role = await roleManager.FindByNameAsync("Patient");
            var user = new User
            {
                //FullName=model.FullName,
                Email = model.Email,
                UserName = model.UserName,
                PhoneNumber = model.PhoneNumber,
                //DateOfBirth=model.DateOfBirth,
                //gender=model.gender,
                userType = UserType.Patient


            };
            var res = await userManager.CreateAsync(user, model.Password);
            if (!res.Succeeded)
            {
                var err = string.Empty;
                foreach (var error in res.Errors)
                {
                    err += $"{error.Description} ,";
                }
                return new AuthModel { Message = err };
            }
            await userManager.AddToRoleAsync(user, "Patient");
            var jwtSecurityToken = await CreateJwtToken(user);
            return new AuthModel
            {
                Email = user.Email,
                ExpireOn = jwtSecurityToken.ValidTo,
                IsAuthenticated = true,
                Role = "Patient",
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                UserName = user.UserName
            };

        }

        private async Task<JwtSecurityToken> CreateJwtToken(User user)
        {
            var userClaims = await userManager.GetClaimsAsync(user);
            var roles = await userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>();

            foreach (var role in roles)
                roleClaims.Add(new Claim("roles", role));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
            issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddHours(_jwt.DurationInDays),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }
    }
}
