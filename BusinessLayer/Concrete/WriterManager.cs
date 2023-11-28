using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerdal;
		public WriterManager(IWriterDal writerdal)
		{
			_writerdal = writerdal;
		}

        public List<Writer> GetList()
        {
            throw new System.NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x=>x.WriterID==id);
        }

        public void TAdd(Writer t)
        {
            _writerdal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new System.NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return _writerdal.GetByID(id);
        }

        public void TUpdate(Writer t)
        {
            throw new System.NotImplementedException();
        }
    }


	
}
