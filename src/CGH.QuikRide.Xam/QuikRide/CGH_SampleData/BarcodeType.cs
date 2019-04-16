// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;
using CGH.QuikRide.DTO.QR;

namespace CGH.QuikRide.DTO.QR
{
	public static class DemoBarcodeType
	{
		public static int SampleBarcodeTypeId0000 = 870208585;
		public static int SampleBarcodeTypeId0100 = 1561712054;

		public static BarcodeType SampleBarcodeType00
		{
			get
			{
				return new BarcodeType()
				{
					BarcodeTypeId = SampleBarcodeTypeId0000,
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
		public static BarcodeType SampleBarcodeType01
		{
			get
			{
				return new BarcodeType()
				{
					BarcodeTypeId = SampleBarcodeTypeId0100,
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