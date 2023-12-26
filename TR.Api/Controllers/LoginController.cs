using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TR.Api.Model;
using TR.BussinessLayer.Models;
using TR.EntityLayer;

namespace TR.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[AllowAnonymous]
	public class LoginController : ControllerBase
	{
		private readonly SignInManager<AppNetUser> _signInManager;
		private readonly UserManager<AppNetUser> _userManager;
		private readonly IConfiguration _configuration;
		private readonly IServiceProvider _serviceProvider;

		public LoginController(UserManager<AppNetUser> userManager, SignInManager<AppNetUser> signInManager, IConfiguration configuration, IServiceProvider serviceProvider)
		{
			_signInManager = signInManager;
			_userManager = userManager;
			_configuration = configuration;
			_serviceProvider = serviceProvider;
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginVM model)
		{
			var user = _userManager.Users.FirstOrDefault(x => x.Email == model.Email);
			if (user != null)
			{
				var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true); // Şifre doğrulama işlemi
				if (result.Succeeded)
				{
					var createToken = new CreateToken(_configuration, _serviceProvider); // CreateToken örneği oluşturuluyor
					var token = createToken.GenerateJwtToken(user); // Token üretimi
					return Ok(new { token });
				}
			}
			return Unauthorized();
		}

	}
}
