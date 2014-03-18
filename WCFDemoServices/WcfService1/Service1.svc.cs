using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Resources;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using WcfService1.Properties;


namespace WcfService1
{
	
	public class ShawServices : IFeaturedItems, IGalleries
	{

		/* IFeaturedItems Begin */

		public IEnumerable<FeaturedItems> GetAllItems(string host, string version)
		{
			string endpoint = Resources.featureditems_getall_endpoint;
            string json = Utilities.GetEndpointData(Utilities.MakeUri(host, version, endpoint));
			return JsonConvert.DeserializeObject<List<FeaturedItems>>(json);
		}

		public FeaturedItems GetItem(string host, string version, string id)
		{
			string endpoint = Resources.featureditems_getitem_endpoint;
            string uri = string.Format(Utilities.MakeUri(host, version, endpoint) + "/" + id);
			string json = Utilities.GetEndpointData(uri);
			return JsonConvert.DeserializeObject<FeaturedItems>(json);
		}

        /* IFeaturedItems End */


        /* IGalleries Begin */

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json)]
        public string GetAll(string host, string version)
        {
            string uri = "http://api.slice.dev.smdg.ca/latest/featureditems/id";
            return Utilities.GetEndpointData(uri);
        }
        
        
        /* IGalleries End */

	}
}
