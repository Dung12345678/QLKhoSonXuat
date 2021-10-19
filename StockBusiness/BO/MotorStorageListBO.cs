
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
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
	