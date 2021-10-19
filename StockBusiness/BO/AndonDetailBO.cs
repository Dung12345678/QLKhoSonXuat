
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class AndonDetailBO : BaseBO
	{
		private AndonDetailFacade facade = AndonDetailFacade.Instance;
		protected static AndonDetailBO instance = new AndonDetailBO();

		protected AndonDetailBO()
		{
			this.baseFacade = facade;
		}

		public static AndonDetailBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	