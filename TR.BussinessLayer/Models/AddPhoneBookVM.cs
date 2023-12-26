using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.BussinessLayer.Models
{
	public class AddPhoneBookVM
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public long Phone { get; set; }
		public string Token { get; set; }
		public bool? Active { get; set; }
		public DateTime? CreateTime { get; set; } = DateTime.Now;
		public string? CreateName { get; set; }
		public int? UserId { get; set; }
	}
}
