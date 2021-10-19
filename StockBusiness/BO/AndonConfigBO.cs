
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class AndonConfigBO : BaseBO
	{
		private AndonConfigFacade facade = AndonConfigFacade.Instance;
		protected static AndonConfigBO instance = new AndonConfigBO();

		protected AndonConfigBO()
		{
			this.baseFacade = facade;
		}

		public static AndonConfigBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	