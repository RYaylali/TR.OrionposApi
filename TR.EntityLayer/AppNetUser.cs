﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.EntityLayer
{
	public class AppNetUser : IdentityUser<int>
	{
		public string Name { get; set; }
		public List<PhoneBook> PhoneBooks { get; set; }
		public AppNetUser()
		{
			PhoneBooks = new List<PhoneBook>();
		}
	}
}
