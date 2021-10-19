
using System;
namespace ST.Model
{
	public class MotorPartListDetailsModel : BaseModel
	{
		private int iD;
		private int partID;
		private string partCode;
		private int positionID;
		private string positionCode;
		private int quantity;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int PartID
		{
			get { return partID; }
			set { partID = value; }
		}
	
		public string PartCode
		{
			get { return partCode; }
			set { partCode = value; }
		}
	
		public int PositionID
		{
			get { return positionID; }
			set { positionID = value; }
		}
	
		public string PositionCode
		{
			get { return positionCode; }
			set { positionCode = value; }
		}
	
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	
	}
}
	