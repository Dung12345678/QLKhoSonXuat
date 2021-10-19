
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class ProductCheckHistoryDetailBO : BaseBO
	{
		private ProductCheckHistoryDetailFacade facade = ProductCheckHistoryDetailFacade.Instance;
		protected static ProductCheckHistoryDetailBO instance = new ProductCheckHistoryDetailBO();

		protected ProductCheckHistoryDetailBO()
		{
			this.baseFacade = facade;
		}

		public static ProductCheckHistoryDetailBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	