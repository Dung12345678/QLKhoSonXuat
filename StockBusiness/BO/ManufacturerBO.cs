
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class ManufacturerBO : BaseBO
	{
		private ManufacturerFacade facade = ManufacturerFacade.Instance;
		protected static ManufacturerBO instance = new ManufacturerBO();

		protected ManufacturerBO()
		{
			this.baseFacade = facade;
		}

		public static ManufacturerBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	