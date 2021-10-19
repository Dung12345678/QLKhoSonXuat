
using System;
using System.Collections;
using ST.Exceptions;
using ST.Utils;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class EventsLogErrorBO : BaseBO
	{
		private EventsLogErrorFacade facade = EventsLogErrorFacade.Instance;
		protected static EventsLogErrorBO instance = new EventsLogErrorBO();

		protected EventsLogErrorBO()
		{
			this.baseFacade = facade;
		}

		public static EventsLogErrorBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	