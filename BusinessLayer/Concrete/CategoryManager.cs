﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void CategoryAdd(Category category)
		{
			_categoryDal.Insert(category);

		}

		public void CategoryDelete(Category category)
		{
			_categoryDal.Delete(category);


		}

		public void CategoryUpdate(Category category)
		{
			throw new System.NotImplementedException();
		}

		public Category GetById(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public List<Category> GetList()
		{
			return _categoryDal.GetListAll();
		}
	}
}
