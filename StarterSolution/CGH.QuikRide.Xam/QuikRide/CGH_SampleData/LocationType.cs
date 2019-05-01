// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;
using CGH.QuikRide.DTO.QR;

namespace CGH.QuikRide.DTO.QR
{
	public static class DemoLocationType
	{
		public static int SampleLocationTypeId0000 = 1912538968;
		public static int SampleLocationTypeId0100 = 373948785;

		public static LocationType SampleLocationType00
		{
			get
			{
				return new LocationType()
				{
					LocationTypeId = SampleLocationTypeId0000,
					Code = "SampleCode",
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static LocationType SampleLocationType01
		{
			get
			{
				return new LocationType()
				{
					LocationTypeId = SampleLocationTypeId0100,
					Code = "SampleCode",
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}

	}
}
