using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TR.BussinessLayer.Abstract;
using TR.BussinessLayer.Models;
using TR.EntityLayer;

namespace TR.Api.Controllers
{
	[AllowAnonymous]
	//[Authorize(Roles ="User")]
	[Route("api/[controller]")]
	[ApiController]
	public class PhoneBookController : ControllerBase
	{
		private readonly IPhoneBookService _phonebookService;
		private readonly UserManager<AppNetUser> _userManager;
		private readonly IMapper _mapper;

		public PhoneBookController(IPhoneBookService phonebookService, IMapper mapper, UserManager<AppNetUser> userManager)
		{
			_phonebookService = phonebookService;
			_mapper = mapper;
			_userManager = userManager;
		}
		[HttpGet("List")]
		public IActionResult PhoneBookList()
		{
			var values = _phonebookService.TGetList();
			var active=values.Where(x=>x.Active==true).ToList();
			return Ok(active);
		}
		[HttpPost("Add")]
		public async Task<IActionResult> AddPhoneBook(AddPhoneBookVM model)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			var values = _mapper.Map<PhoneBook>(model);
			values.CreateName= user.UserName;
			values.UserId = user.Id;
			_phonebookService.TInsert(values);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeletePhoneBook(int id)
		{
			_phonebookService.TSoftDelete(id);
			return Ok();
		}
		[HttpPut("{id}")]
		public IActionResult UpdatePhoneBook(UpdatePhoneBookVM model)
		{
			var values = _mapper.Map<PhoneBook>(model);
			_phonebookService.TUpdate(values);
			return Ok(model);
		}
		[HttpGet("{id}")]
		public IActionResult GetPhoneBook(int id)
		{
			var values = _phonebookService.TGetByID(id);
			return Ok(values);
		}
	}
}
