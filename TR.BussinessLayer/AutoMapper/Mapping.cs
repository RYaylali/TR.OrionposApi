using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.BussinessLayer.Models;
using TR.EntityLayer;

namespace TR.BussinessLayer.AutoMapper
{
	public class Mapping : Profile
	{
        public Mapping()
        {
			CreateMap<AppNetUser, LoginVM>().ReverseMap();
			CreateMap<PhoneBook, AddPhoneBookVM>().ReverseMap();
			CreateMap<PhoneBook, UpdatePhoneBookVM>().ReverseMap();
		}
    }
}
