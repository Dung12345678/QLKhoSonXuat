
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class SonPlanBO : BaseBO
	{
		private SonPlanFacade facade = SonPlanFacade.Instance;
		protected static SonPlanBO instance = new SonPlanBO();

		protected SonPlanBO()
		{
			this.baseFacade = facade;
		}

		public static SonPlanBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	