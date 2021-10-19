
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class UserGroupLinkFacade : BaseFacade
	{
		protected static UserGroupLinkFacade instance = new UserGroupLinkFacade(new UserGroupLinkModel());
		protected UserGroupLinkFacade(UserGroupLinkModel model) : base(model)
		{
		}
		public static UserGroupLinkFacade Instance
		{
			get { return instance; }
		}
		protected UserGroupLinkFacade():base() 
		{ 
		} 
	
	}
}
	