using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsletterdal;

		public NewsLetterManager(INewsLetterDal newsletterdal)  // newslettermanagera ctrl . deyip olusturucuyu olustur diyoruz
		{
			_newsletterdal = newsletterdal;
		}

		public void AddNewsLetter(NewsLetter newsletter)
		{
			_newsletterdal.Insert(newsletter);
		}
	}
}
