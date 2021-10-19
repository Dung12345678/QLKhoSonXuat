
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class MotorStorageListBO : BaseBO
	{
		private MotorStorageListFacade facade = MotorStorageListFacade.Instance;
		protected static MotorStorageListBO instance = new MotorStorageListBO();

		protected MotorStorageListBO()
		{
			this.baseFacade = facade;
		}

		public static MotorStorageListBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	