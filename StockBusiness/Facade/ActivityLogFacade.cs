
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class ActivityLogFacade : BaseFacade
	{
		protected static ActivityLogFacade instance = new ActivityLogFacade(new ActivityLogModel());
		protected ActivityLogFacade(ActivityLogModel model) : base(model)
		{
		}
		public static ActivityLogFacade Instance
		{
			get { return instance; }
		}
		protected ActivityLogFacade():base() 
		{ 
		} 
	
	}
}
	