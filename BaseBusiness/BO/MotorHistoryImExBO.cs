
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class MotorHistoryImExBO : BaseBO
	{
		private MotorHistoryImExFacade facade = MotorHistoryImExFacade.Instance;
		protected static MotorHistoryImExBO instance = new MotorHistoryImExBO();

		protected MotorHistoryImExBO()
		{
			this.baseFacade = facade;
		}

		public static MotorHistoryImExBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	