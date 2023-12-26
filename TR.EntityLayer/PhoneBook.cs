using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.EntityLayer
{
	public class PhoneBook
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long Phone { get; set; }
        public bool Active { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateName { get; set; }
        public AppNetUser? User { get; set; }
        public int? UserId { get; set; }
    }
}
