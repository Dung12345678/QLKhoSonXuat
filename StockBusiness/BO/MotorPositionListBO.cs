
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class MotorPositionListBO : BaseBO
	{
		private MotorPositionListFacade facade = MotorPositionListFacade.Instance;
		protected static MotorPositionListBO instance = new MotorPositionListBO();

		protected MotorPositionListBO()
		{
			this.baseFacade = facade;
		}

		public static MotorPositionListBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	