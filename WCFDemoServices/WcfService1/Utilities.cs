using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WcfService1
{
    public class Utilities
    {
        public static string MakeUri(string host, string version, string endpoint)
        {
            string uri = string.Format(
                    "http://{0}/{1}/{2}",
                    host,
                    version,
                    endpoint);

            return uri;
        }

        public static string GetEndpointData(string endpoint)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(endpoint);
            return reply;
        }
    }
}