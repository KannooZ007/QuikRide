// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.1, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace CGH.QuikRide.Model.QR.Interface
{
	public partial interface IRide
	{
		string CreatedBy { get; }
		System.DateTime CreatedUtcDate { get; }
		int DataVersion { get; }
		int DriverId { get; }
		int? DurationInSeconds { get; }
		System.DateTime? End { get; }
		double? EndLatitude { get; }
		double? EndLongitude { get; }
		int? GeoDistance { get; }
		bool IsDeleted { get; }
		string ModifiedBy { get; }
		System.DateTime ModifiedUtcDate { get; }
		System.Guid RideId { get; }
		System.DateTime? Start { get; }
		double? StartLatitude { get; }
		double? StartLongitude { get; }
		int UserId { get; }
		int VehicleId { get; }

		IDriver Driver { get; }
		IUser User { get; }
		IVehicle Vehicle { get; }
		List<IRidePosition> RidePositions { get; }


	}
}