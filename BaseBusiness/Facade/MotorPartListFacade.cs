
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class MotorPartListFacade : BaseFacade
	{
		protected static MotorPartListFacade instance = new MotorPartListFacade(new MotorPartListModel());
		protected MotorPartListFacade(MotorPartListModel model) : base(model)
		{
		}
		public static MotorPartListFacade Instance
		{
			get { return instance; }
		}
		protected MotorPartListFacade():base() 
		{ 
		} 
	
	}
}
	