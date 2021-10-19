
using System.Collections;
using ST.Model;
namespace ST.Facade
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
	