// <auto-generated> - Template:SqliteModelData, Version:1.1, Id:c5caad15-b3be-4443-87d8-7cabde59f7b0
using SQLite;

namespace CGH.QuikRide.Xam.ModelData.QR
{
	[Table("VehicleType")]
	public partial class VehicleType
	{
		public int? Capacity { get; set; }
		public string Code { get; set; }
		public string CreatedBy { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public int DataVersion { get; set; }
		public string Description { get; set; }
		public int DisplayPriority { get; set; }
		public string DisplayText { get; set; }
		public double? FrontOverhangInFeet { get; set; }
		public double? GroundClearanceInFeet { get; set; }
		public double? HeightInFeet { get; set; }
		public bool IsDeleted { get; set; }
		public double? LengthInFeetMax { get; set; }
		public double? LengthInFeetMin { get; set; }
		public double? LengthWithBumpers { get; set; }
		public string ModifiedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public double? RearOverhangInFeet { get; set; }

		[PrimaryKey]
		public int VehicleTypeId { get; set; }

		public double? WheelbaseInFeet { get; set; }
		public double? WidthInFeet { get; set; }
		public double? WidthWithMirrorsInFeet { get; set; }
	}
}
