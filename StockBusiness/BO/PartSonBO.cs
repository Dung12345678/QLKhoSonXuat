
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class PartSonBO : BaseBO
	{
		private PartSonFacade facade = PartSonFacade.Instance;
		protected static PartSonBO instance = new PartSonBO();

		protected PartSonBO()
		{
			this.baseFacade = facade;
		}

		public static PartSonBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	