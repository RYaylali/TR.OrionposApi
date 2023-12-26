﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		List<T> GetList();
		T GetByID(int id);
		void SoftDelete(int id);
	}
}
