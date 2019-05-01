// <auto-generated> - Template:SqliteModelData, Version:1.1, Id:c5caad15-b3be-4443-87d8-7cabde59f7b0
using SQLite;

namespace CGH.QuikRide.Xam.ModelData.QR
{
	[Table("Holiday")]
	public partial class Holiday
	{
		public string Code { get; set; }
		public string CreatedBy { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public int DataVersion { get; set; }
		public System.DateTime Date { get; set; }

		[PrimaryKey]
		public int HolidayId { get; set; }

		public bool IsDeleted { get; set; }
		public string ModifiedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
	}
}
