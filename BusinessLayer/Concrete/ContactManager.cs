using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactDal _contactdal;

		public ContactManager(IContactDal contactdal)
		{
			_contactdal = contactdal;
		}

		public void ContactAdd(Contact contact)
		{
			_contactdal.Insert(contact);
		}
	}
}
