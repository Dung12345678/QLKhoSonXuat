
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class WorkingFacade : BaseFacade
	{
		protected static WorkingFacade instance = new WorkingFacade(new WorkingModel());
		protected WorkingFacade(WorkingModel model) : base(model)
		{
		}
		public static WorkingFacade Instance
		{
			get { return instance; }
		}
		protected WorkingFacade():base() 
		{ 
		} 
	
	}
}
	