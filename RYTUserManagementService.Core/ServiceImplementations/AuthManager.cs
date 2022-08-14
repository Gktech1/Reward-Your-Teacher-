
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RYTUserManagementService.Core.ServiceInterfaces;
using RYTUserManagementService.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using RYTUserManagementService.Dto;

namespace RYTUserManagementService.Core.ServiceImplementations
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly IConfiguration _configuration;
        

        public AuthManager(UserManager<ApiUser> userManager, IConfiguration configuration/*, ApiUser user*/)
        {
            _userManager = userManager;
            _configuration = configuration;
           
        }
        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials(_configuration);
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions((SigningCredentials)signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }


        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)  
        {
            var jwt = _configuration.GetSection("Jwt");
            var expiration = DateTime.Now.AddMinutes(Convert.ToDouble(
                jwt.GetSection("lifetime").Value));
            var token = new JwtSecurityToken(
                issuer: jwt.GetSection("validIssuer").Value,
                claims: claims,
                expires: expiration,
                signingCredentials: signingCredentials
                );

            return token;
        }

        private readonly ApiUser user;

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };
            var roles = await _userManager.GetRolesAsync(user);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private object GetSigningCredentials(IConfiguration configuration)
        {
            var jwt = configuration.GetSection("Jwt");
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Key"));

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);

        }

        public async Task<bool> ValidateUser(LoginUserDto userDto)
        {
            var user = await _userManager.FindByNameAsync(userDto.Email);
            return (user != null && await  _userManager.CheckPasswordAsync(user, userDto.Password));
        }
    }
}
