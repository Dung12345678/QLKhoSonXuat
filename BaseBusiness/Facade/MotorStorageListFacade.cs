
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class MotorStorageListFacade : BaseFacade
	{
		protected static MotorStorageListFacade instance = new MotorStorageListFacade(new MotorStorageListModel());
		protected MotorStorageListFacade(MotorStorageListModel model) : base(model)
		{
		}
		public static MotorStorageListFacade Instance
		{
			get { return instance; }
		}
		protected MotorStorageListFacade():base() 
		{ 
		} 
	
	}
}
	