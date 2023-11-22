using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface IBlogService:IGenericService<Blog>
	{
		List<Blog> GetBlogListWithCategory(); // kategoriye göre listeleme gerçekleşiyor
        List<Blog> GetBlogListByWriter(int id); //yazara göre

    }
}
