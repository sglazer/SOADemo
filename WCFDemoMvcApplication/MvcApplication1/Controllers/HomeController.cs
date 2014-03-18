using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;


namespace MvcApplication1.Controllers
{
	public class HomeController : Controller
	{
		string APIHost = ConfigurationManager.AppSettings["APIHost"];
		string FeaturedItemsServiceVersion = ConfigurationManager.AppSettings["FeaturedItemsServiceVersion"];
		
		
		public ActionResult Index()
		{
			ViewBag.Message = "Feel free to modify this site and play around...";
			
			FeaturedItemsModel model = new FeaturedItemsModel();
			ShawServices.FeaturedItemsClient client = new ShawServices.FeaturedItemsClient();
			var items = client.GetItem(APIHost, FeaturedItemsServiceVersion, "311");
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
