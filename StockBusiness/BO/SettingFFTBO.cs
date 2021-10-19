
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class SettingFFTBO : BaseBO
	{
		private SettingFFTFacade facade = SettingFFTFacade.Instance;
		protected static SettingFFTBO instance = new SettingFFTBO();

		protected SettingFFTBO()
		{
			this.baseFacade = facade;
		}

		public static SettingFFTBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	