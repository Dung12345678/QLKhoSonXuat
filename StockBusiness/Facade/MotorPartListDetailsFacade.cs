
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class MotorPartListDetailsFacade : BaseFacade
	{
		protected static MotorPartListDetailsFacade instance = new MotorPartListDetailsFacade(new MotorPartListDetailsModel());
		protected MotorPartListDetailsFacade(MotorPartListDetailsModel model) : base(model)
		{
		}
		public static MotorPartListDetailsFacade Instance
		{
			get { return instance; }
		}
		protected MotorPartListDetailsFacade():base() 
		{ 
		} 
	
	}
}
	