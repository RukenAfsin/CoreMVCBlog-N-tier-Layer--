﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface ICategoryService
	{
		void CategoryAdd(Category category);
		void CategoryDelete(Category category);
		void CategoryUpdate(Category category);
		List<Category> GetList();
		Category GetById(int id);
	}
}
