
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class FormAndFunctionFacade : BaseFacade
	{
		protected static FormAndFunctionFacade instance = new FormAndFunctionFacade(new FormAndFunctionModel());
		protected FormAndFunctionFacade(FormAndFunctionModel model) : base(model)
		{
		}
		public static FormAndFunctionFacade Instance
		{
			get { return instance; }
		}
		protected FormAndFunctionFacade():base() 
		{ 
		} 
	
	}
}
	