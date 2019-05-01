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

    // UserRewardAccountTransaction
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class UserRewardAccountTransactionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserRewardAccountTransaction>
    {
        public UserRewardAccountTransactionConfiguration()
            : this("dbo")
        {
        }

        public UserRewardAccountTransactionConfiguration(string schema)
        {
            ToTable("UserRewardAccountTransaction", schema);
            HasKey(x => x.UserRewardAccountTransactionId);

            Property(x => x.UserRewardAccountTransactionId).HasColumnName(@"UserRewardAccountTransactionId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserRewardAccountId).HasColumnName(@"UserRewardAccountId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.UserRewardAccountTransactionTypeId).HasColumnName(@"UserRewardAccountTransactionTypeId").HasColumnType("int").IsRequired();
            Property(x => x.Value).HasColumnName(@"Value").HasColumnType("int").IsOptional();
            Property(x => x.Memo).HasColumnName(@"Memo").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.DataVersion).HasColumnName(@"DataVersion").HasColumnType("int").IsRequired();
            Property(x => x.CreatedUtcDate).HasColumnName(@"CreatedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ModifiedUtcDate).HasColumnName(@"ModifiedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.UserRewardAccountTransactionType).WithMany(b => b.UserRewardAccountTransactions).HasForeignKey(c => c.UserRewardAccountTransactionTypeId).WillCascadeOnDelete(false); // FK_UserRewardAccountTransaction_UserRewardAccountTransactionType
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
