// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;
using CGH.QuikRide.DTO.QR;

namespace CGH.QuikRide.DTO.QR
{
	public static class DemoUsersLocation
	{
		public static int SampleUsersLocationId0000 = 1856488250;
		public static System.Guid SampleUsersLocationId0001 = Guid.Parse("439de959-db80-439e-97b9-3a884e7c8a52");
		public static int SampleUsersLocationId0100 = 1904134006;
		public static System.Guid SampleUsersLocationId0101 = Guid.Parse("1353f9a0-c593-4d69-a5f1-b60417851f70");

		public static UsersLocation SampleUsersLocation00
		{
			get
			{
				return new UsersLocation()
				{
					UserId = SampleUsersLocationId0100,
					LocationId = SampleUsersLocationId0101,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static UsersLocation SampleUsersLocation01
		{
			get
			{
				return new UsersLocation()
				{
					UserId = SampleUsersLocationId0100,
					LocationId = SampleUsersLocationId0101,
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