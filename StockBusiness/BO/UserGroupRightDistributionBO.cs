
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class UserGroupRightDistributionBO : BaseBO
	{
		private UserGroupRightDistributionFacade facade = UserGroupRightDistributionFacade.Instance;
		protected static UserGroupRightDistributionBO instance = new UserGroupRightDistributionBO();

		protected UserGroupRightDistributionBO()
		{
			this.baseFacade = facade;
		}

		public static UserGroupRightDistributionBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	