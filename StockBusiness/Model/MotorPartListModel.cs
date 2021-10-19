
using System;
namespace ST.Model
{
	public class MotorPartListModel : BaseModel
	{
		private int iD;
		private string partCode;
		private int quantity;
		private string description;
		private DateTime? createdDate;
		private DateTime? modifiedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string PartCode
		{
			get { return partCode; }
			set { partCode = value; }
		}
	
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	
		public DateTime? CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}
	
		public DateTime? ModifiedDate
		{
			get { return modifiedDate; }
			set { modifiedDate = value; }
		}
	
	}
}
	