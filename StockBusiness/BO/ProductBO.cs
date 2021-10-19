
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class ProductBO : BaseBO
	{
		private ProductFacade facade = ProductFacade.Instance;
		protected static ProductBO instance = new ProductBO();

		protected ProductBO()
		{
			this.baseFacade = facade;
		}

		public static ProductBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	