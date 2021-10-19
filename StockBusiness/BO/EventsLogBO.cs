using System;
using System.Collections;
using ST.BO;
using ST.Exceptions;
using ST.Utils;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class EventsLogBO : BaseBO
	{
		private EventsLogFacade facade = EventsLogFacade.Instance;
		protected static EventsLogBO instance = new EventsLogBO();

		protected EventsLogBO()
		{
			this.baseFacade = facade;
		}

		public static EventsLogBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	