
using System;
namespace ST.Model
{
	public class MotorStorageListModel : BaseModel
	{
		private int iD;
		private string storageCode;
		private string storageName;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string StorageCode
		{
			get { return storageCode; }
			set { storageCode = value; }
		}
	
		public string StorageName
		{
			get { return storageName; }
			set { storageName = value; }
		}
	
	}
}
	