
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class AndonDetailFacade : BaseFacade
	{
		protected static AndonDetailFacade instance = new AndonDetailFacade(new AndonDetailModel());
		protected AndonDetailFacade(AndonDetailModel model) : base(model)
		{
		}
		public static AndonDetailFacade Instance
		{
			get { return instance; }
		}
		protected AndonDetailFacade():base() 
		{ 
		} 
	
	}
}
	