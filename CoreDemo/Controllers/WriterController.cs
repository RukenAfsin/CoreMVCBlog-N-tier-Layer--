using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult WriterProfile()
		{
			return View();
		}

		public IActionResult WriterMail()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}

		[AllowAnonymous]
		public PartialViewResult WriterNavBarPartial()
		{
			return PartialView();
		}


        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}

        [AllowAnonymous]
        public IActionResult WriterEditProfile()
        {
			var writervalues = wm.TGetById(1);
			return View(writervalues);
        }
    }
}
