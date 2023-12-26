using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TR.EntityLayer;

namespace TR.Api.Model
{
	public class CreateToken
	{
		private readonly IConfiguration _configuration;
		private readonly IServiceProvider _serviceProvider;

		public CreateToken(IConfiguration configuration, IServiceProvider serviceProvider)
		{
			_configuration = configuration;
			_serviceProvider = serviceProvider;
		}

		public string GenerateJwtToken(AppNetUser user)
		{
			using (var scope = _serviceProvider.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppNetUser>>();

				var jwtSettings = _configuration.GetSection("JwtSettings");
				var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));
				var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
				var claims = new List<Claim>
				{
					new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
					new Claim(JwtRegisteredClaimNames.Email, user.Email),
					new Claim(ClaimTypes.Role,"User"),
					new Claim(ClaimTypes.Name,user.UserName)
				};
				var userRoles = userManager.GetRolesAsync(user).Result; // UserManager üzerinden rolleri alın
				foreach (var role in userRoles)
				{
					claims.Add(new Claim(ClaimTypes.Role, role));
				}

				var token = new JwtSecurityToken(
				issuer: jwtSettings["Jwt:Issuer"], // Veren (Issuer)
				audience: jwtSettings["Jwt:Audience"], // İzleyici (Audience)
				claims: claims,
				expires: DateTime.UtcNow.AddHours(2), // Token süresi, UTC olarak ayarlandı
				signingCredentials: creds
				);
				var tokenHandler = new JwtSecurityTokenHandler();
				return tokenHandler.WriteToken(token);

			}
		}
	}
}
