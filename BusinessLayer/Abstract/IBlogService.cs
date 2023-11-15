using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogUpdate(Blog blog);
		List<Blog> GetBlogListByWriter();
		Blog GetById(int id);
		List<Blog> GetBlogListWithCategory(); // kategoriye göre listeleme gerçekleşiyor
		List<Blog> GetBlogListByWriter(int id);   //yazara göre

	}
}
