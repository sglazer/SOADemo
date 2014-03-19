using System.Configuration;
namespace System.Web.Mvc
{
	public static class HtmlHelperExtention
	{
		public static string FullImageUrl(this HtmlHelper htmlHelper, string url)
		{
			if (!url.StartsWith("http"))
			{
				return string.Format("{0}{1}", ConfigurationManager.AppSettings["ImageBaseUrl"], url.ToLower());
			}
			return string.IsNullOrEmpty(url) ? string.Empty : url;
		}
	}
}