using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.EntityLayer;

namespace TR.BussinessLayer.Abstract
{
	public interface IPhoneBookService :IGenericService<PhoneBook>
	{
		void TSoftDelete(int id);
	}
}
