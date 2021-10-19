
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class MotorPositionListFacade : BaseFacade
	{
		protected static MotorPositionListFacade instance = new MotorPositionListFacade(new MotorPositionListModel());
		protected MotorPositionListFacade(MotorPositionListModel model) : base(model)
		{
		}
		public static MotorPositionListFacade Instance
		{
			get { return instance; }
		}
		protected MotorPositionListFacade():base() 
		{ 
		} 
	
	}
}
	