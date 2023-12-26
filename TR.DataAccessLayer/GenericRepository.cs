using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.DataAccessLayer.Abstract;

namespace TR.DataAccessLayer
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		private readonly Context _context;

		public GenericRepository(Context context)
		{
			_context = context;
		}

		public void Delete(T entity)
		{
			_context.Remove(entity);
			_context.SaveChanges();
		}
		public T GetByID(int id)
		{
			return _context.Set<T>().Find(id);
		}
		public List<T> GetList()
		{
			return _context.Set<T>().ToList();
		}
		public void Insert(T entity)
		{
			_context.Add(entity);
			_context.SaveChanges();
		}
		public void Update(T entity)
		{
			_context.Update(entity);
			_context.SaveChanges();
		}
		public void SoftDelete(int id)
		{
			var values = _context.PhoneBooks.FirstOrDefault(x => x.Id == id);
			if (values != null)
			{
				values.Active = false;
				_context.SaveChanges();
			}
		}
	}
}
