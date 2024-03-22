using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebJobMatchingAPI.Data;
using WebJobMatchingAPI.DTO;
using WebJobMatchingAPI.Entities;
using WebJobMatchingAPI.Utils;

namespace WebJobMatchingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DBContext _context;
        private readonly AppSetting _appSettings;

        public AuthController(DBContext context, IOptionsMonitor<AppSetting> optionsMonitor)
        {
            _context = context;
            _appSettings = optionsMonitor.CurrentValue;
        }

        [HttpPost]
        public IActionResult login(LoginModel model)
        {
            var user = _context.Users.SingleOrDefault(m => m.UserName == model.UserName && m.Password == model.Password);
            if (user == null) // if login invalid
            {
                return Ok(new APIResponse
                {
                    Success = false,
                    Message = "Invalid username or password"
                }) ;
            }
            //else generated token
            return Ok(new APIResponse
            {
                Success = true,
                Message = "Login successfully",
                Data = generateToken(user)
            }); ;
        }

        private string generateToken(Users users)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var secretKeyBytes = Encoding.UTF8.GetBytes(_appSettings.SecretKey);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, users.Email),
                    new Claim(ClaimTypes.Name, users.FirstName),
                    new Claim("UserName", users.UserName),
                    new Claim("Id", users.ID.ToString()),

                    //roles

                    new Claim("TokenId", Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(1), //1 phut
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha256)
            };
            var token = jwtTokenHandler.CreateToken(tokenDescription);
            return jwtTokenHandler.WriteToken(token);
        }
    }
}
