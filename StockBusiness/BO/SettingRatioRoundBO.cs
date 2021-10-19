
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class SettingRatioRoundBO : BaseBO
	{
		private SettingRatioRoundFacade facade = SettingRatioRoundFacade.Instance;
		protected static SettingRatioRoundBO instance = new SettingRatioRoundBO();

		protected SettingRatioRoundBO()
		{
			this.baseFacade = facade;
		}

		public static SettingRatioRoundBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	