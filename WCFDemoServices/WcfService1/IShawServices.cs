using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
	
	[ServiceContract]
	public interface IFeaturedItems
	{
		[OperationContract]
		string GetAllItems(string host, string version);

		[OperationContract]
		string GetItem(string host, string version, string id);
	}

    [ServiceContract]
    public interface IGalleries
    {
        [OperationContract]
        string GetAll(string host, string version);
    }


	
}
