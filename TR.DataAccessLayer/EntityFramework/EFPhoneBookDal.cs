using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.DataAccessLayer.Abstract;
using TR.EntityLayer;

namespace TR.DataAccessLayer.EntityFramework
{
	public class EFPhoneBookDal : GenericRepository<PhoneBook>, IPhoneBookDal
	{
		public EFPhoneBookDal(Context context) : base(context)
		{
		}
	}
}
