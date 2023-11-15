using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerdal;
		public WriterManager(IWriterDal writerdal)
		{
			_writerdal = writerdal;
		}

		public void WriterAdd(Writer writer)
		{
			_writerdal.Insert(writer);
		}


	}
}
