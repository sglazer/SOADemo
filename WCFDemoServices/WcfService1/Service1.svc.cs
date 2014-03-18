using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService1
{
	
	public class ShawServices : IFeaturedItems, IGalleries
	{
		/* IFeaturedItems Begin */
        
        [WebInvoke(Method = "GET",
		ResponseFormat = WebMessageFormat.Json)]
		public string GetAllItems(string host, string version)
		{
			//string endpoint = "http://api.slice.dev.smdg.ca/latest/featureditems";
			string endpoint = "featureditems";
            return Utilities.GetEndpointData(Utilities.MakeUri(host, version, endpoint));
		}

		[WebInvoke(Method = "GET",
		ResponseFormat = WebMessageFormat.Json)]
		public string GetItem(string host, string version, string id)
		{
			//string endpoint = "http://api.slice.dev.smdg.ca/latest/featureditems/id";
			string endpoint = "featureditems";
            string uri = string.Format(Utilities.MakeUri(host, version, endpoint) + "/" + id);
			return Utilities.GetEndpointData(uri);
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
