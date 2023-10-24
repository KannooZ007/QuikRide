// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CGH.QuikRide.Repository.Entities.QR
{

    // BarcodeScanLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class BarcodeScanLog
    {
        public System.Guid BarcodeScanLogId { get; set; } // BarcodeScanLogId (Primary key)
        public System.Guid BarcodeId { get; set; } // BarcodeId
        public int UserId { get; set; } // UserId
        public string DeviceOperatingSystem { get; set; } // DeviceOperatingSystem (length: 255)
        public string DeviceOperatingSystemVersion { get; set; } // DeviceOperatingSystemVersion (length: 255)
        public double? Latitude { get; set; } // Latitude
        public double? Longitude { get; set; } // Longitude
        public string DataJson { get; set; } // DataJson (length: 4000)
        public int DataVersion { get; set; } // DataVersion
        public System.DateTime CreatedUtcDate { get; set; } // CreatedUtcDate
        public string CreatedBy { get; set; } // CreatedBy (length: 200)
        public System.DateTime ModifiedUtcDate { get; set; } // ModifiedUtcDate
        public string ModifiedBy { get; set; } // ModifiedBy (length: 200)
        public bool IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent Barcode pointed by [BarcodeScanLog].([BarcodeId]) (FK_BarcodeScanLog_Barcode)
        /// </summary>
        public Barcode Barcode { get; set; } // FK_BarcodeScanLog_Barcode

        public BarcodeScanLog()
        {
            DataVersion = 1;
            CreatedUtcDate = System.DateTime.UtcNow;
            ModifiedUtcDate = System.DateTime.UtcNow;
            IsDeleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>