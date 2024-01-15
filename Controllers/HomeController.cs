using Simple_Ecommerce_Proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Simple_Ecommerce_Proj.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		private fShopDB db = new fShopDB();
		public ActionResult DisplaySuplier(int? page)
		{
			//var a = from s in db.Nha_CC select s;
			//
			var supplies = db.Nha_CC.Select(s => s);
			supplies = supplies.OrderBy(s=> s.MaNCC);
			int pageSize = 3;
			int pageNumber = (page ?? 1);
			return View(supplies.ToPagedList(pageNumber, pageSize));
		}
	}
}