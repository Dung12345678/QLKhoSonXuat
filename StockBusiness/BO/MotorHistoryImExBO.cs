
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
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
	