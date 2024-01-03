using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        //List<Blog> GetListWithCategory();
        //List<Blog> GetListWithCategoryByWriter(int id);
    }
}
