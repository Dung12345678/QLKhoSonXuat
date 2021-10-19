
using System;
namespace ST.Model
{
	public class MotorPositionListModel : BaseModel
	{
		private int iD;
		private string positionCode;
		private string description;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string PositionCode
		{
			get { return positionCode; }
			set { positionCode = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	
	}
}
	