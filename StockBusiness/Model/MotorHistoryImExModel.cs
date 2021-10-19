
using System;
namespace ST.Model
{
	public class MotorHistoryImExModel : BaseModel
	{
		private int iD;
		private int partID;
		private string partCode;
		private DateTime? dateImEx;
		private string workerCode;
		private bool isExported;
		private string positionCode;
		private int positionID;
		private int quantity;
		private int remainQuantity;
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
	
		public DateTime? DateImEx
		{
			get { return dateImEx; }
			set { dateImEx = value; }
		}
	
		public string WorkerCode
		{
			get { return workerCode; }
			set { workerCode = value; }
		}
	
		public bool IsExported
		{
			get { return isExported; }
			set { isExported = value; }
		}
	
		public string PositionCode
		{
			get { return positionCode; }
			set { positionCode = value; }
		}
	
		public int PositionID
		{
			get { return positionID; }
			set { positionID = value; }
		}
	
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	
		public int RemainQuantity
		{
			get { return remainQuantity; }
			set { remainQuantity = value; }
		}
	
	}
}
	