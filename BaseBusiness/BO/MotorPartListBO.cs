
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class MotorPartListBO : BaseBO
	{
		private MotorPartListFacade facade = MotorPartListFacade.Instance;
		protected static MotorPartListBO instance = new MotorPartListBO();

		protected MotorPartListBO()
		{
			this.baseFacade = facade;
		}

		public static MotorPartListBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	