using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}
		public List<Blog> GetBlogById(int id)
		{
			return _blogDal.GetListAll(x => x.BlogID == id);

		}

		public List<Blog> GetBlogListByWriter()
		{
			return _blogDal.GetListAll();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{

			return _blogDal.GetListAll(x => x.WriterID == id);

		}
	}
}
