
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class SupplierFacade : BaseFacade
	{
		protected static SupplierFacade instance = new SupplierFacade(new SupplierModel());
		protected SupplierFacade(SupplierModel model) : base(model)
		{
		}
		public static SupplierFacade Instance
		{
			get { return instance; }
		}
		protected SupplierFacade():base() 
		{ 
		} 
	
	}
}
	