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
		IEnumerable<FeaturedItems> GetAllItems(string host, string version);

		[OperationContract]
		FeaturedItems GetItem(string host, string version, string id);
	}

    [ServiceContract]
    public interface IGalleries
    {
        [OperationContract]
        string GetAll(string host, string version);
    }

	[DataContract]
	public class FeaturedItems
	{
		[DataMember]
		public List<FeaturedItem> Items { get; set; }

		[DataMember]
		public ShawHyperLink TitleLink { get; set; }

		[DataMember]
		public List<ShawHyperLink> Links { get; set; }

		[DataMember]
		public List<string> ViewTypes { get; set; }
	}

	[DataContract]
	public class FeaturedItem
	{
		[DataMember]
		public string ThumbnailURL { get; set; }

		[DataMember]
		public ShawHyperLink TitleLink { get; set; }

		[DataMember]
		public List<ShawHyperLink> CallToActions { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public string ViewType { get; set; }

		[DataMember]
		public string StartDate { get; set; }

		[DataMember]
		public string EndDate { get; set; }
	}

	[DataContract]
	public class ShawHyperLink
	{
		[DataMember]
		public string Href { get; set; }

		[DataMember]
		public string Text { get; set; }
	}


	
	
}
