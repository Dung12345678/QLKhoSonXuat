
using System;
using System.Collections;
using ST.BO;
using ST.Exceptions;
using ST.Utils;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class ActivityLogBO : BaseBO
	{
		private ActivityLogFacade facade = ActivityLogFacade.Instance;
		protected static ActivityLogBO instance = new ActivityLogBO();

		protected ActivityLogBO()
		{
			this.baseFacade = facade;
		}

		public static ActivityLogBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	