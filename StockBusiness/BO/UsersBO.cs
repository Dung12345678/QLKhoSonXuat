
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class UsersBO : BaseBO
	{
		private UsersFacade facade = UsersFacade.Instance;
		protected static UsersBO instance = new UsersBO();

		protected UsersBO()
		{
			this.baseFacade = facade;
		}

		public static UsersBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	