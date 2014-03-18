using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;


namespace MvcApplication1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
			FeaturedItemsModel model = new FeaturedItemsModel();
			ShawServices.FeaturedItemsClient client = new ShawServices.FeaturedItemsClient();
			var items = client.GetItem("api.slice.dev.smdg.ca", "latest", "311");
			model.EditorsPicks = items;
			return View(model);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
