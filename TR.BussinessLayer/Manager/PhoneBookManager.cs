using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.BussinessLayer.Abstract;
using TR.DataAccessLayer.Abstract;
using TR.DataAccessLayer.EntityFramework;
using TR.EntityLayer;

namespace TR.BussinessLayer.Manager
{
	public class PhoneBookManager : IPhoneBookService
	{
		private readonly IPhoneBookDal  _phoneBookDal;

		public PhoneBookManager(IPhoneBookDal phoneBookService)
		{
			_phoneBookDal = phoneBookService;
		}

		public void TDelete(PhoneBook entity)
		{
			_phoneBookDal.Delete(entity);
		}

		public PhoneBook TGetByID(int id)
		{
			return _phoneBookDal.GetByID(id);
		}

		public List<PhoneBook> TGetList()
		{
			return _phoneBookDal.GetList();
		}

		public void TInsert(PhoneBook entity)
		{
			_phoneBookDal.Insert(entity);
		}

		public void TSoftDelete(int id)
		{
			_phoneBookDal.SoftDelete(id);
		}

		public void TUpdate(PhoneBook entity)
		{
			_phoneBookDal.Update(entity);	
		}
	}
}
