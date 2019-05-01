// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace CGH.QuikRide.Xam.ModelObj.QR
{
	public partial class UserRewardAccountTransaction : ObservableObject
	{
		public UserRewardAccountTransaction()
		{
			InitializePartial();
		}

		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private bool _isDeleted;
		private string _memo;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private System.Guid _userRewardAccountId;
		private System.Guid _userRewardAccountTransactionId;
		private int _userRewardAccountTransactionTypeId;
		private int? _value;


		public string CreatedBy
		{
			get { return _createdBy; }
			set
			{
				Set<string>(() => CreatedBy, ref _createdBy, value);
				RunCustomLogicSetCreatedBy(value);
			}
		}

		public System.DateTime CreatedUtcDate
		{
			get { return _createdUtcDate; }
			set
			{
				Set<System.DateTime>(() => CreatedUtcDate, ref _createdUtcDate, value);
				RunCustomLogicSetCreatedUtcDate(value);
			}
		}

		public int DataVersion
		{
			get { return _dataVersion; }
			set
			{
				Set<int>(() => DataVersion, ref _dataVersion, value);
				RunCustomLogicSetDataVersion(value);
			}
		}

		public bool IsDeleted
		{
			get { return _isDeleted; }
			set
			{
				Set<bool>(() => IsDeleted, ref _isDeleted, value);
				RunCustomLogicSetIsDeleted(value);
			}
		}

		public string Memo
		{
			get { return _memo; }
			set
			{
				Set<string>(() => Memo, ref _memo, value);
				RunCustomLogicSetMemo(value);
			}
		}

		public string ModifiedBy
		{
			get { return _modifiedBy; }
			set
			{
				Set<string>(() => ModifiedBy, ref _modifiedBy, value);
				RunCustomLogicSetModifiedBy(value);
			}
		}

		public System.DateTime ModifiedUtcDate
		{
			get { return _modifiedUtcDate; }
			set
			{
				Set<System.DateTime>(() => ModifiedUtcDate, ref _modifiedUtcDate, value);
				RunCustomLogicSetModifiedUtcDate(value);
			}
		}

		public System.Guid UserRewardAccountId
		{
			get { return _userRewardAccountId; }
			set
			{
				Set<System.Guid>(() => UserRewardAccountId, ref _userRewardAccountId, value);
				RunCustomLogicSetUserRewardAccountId(value);
			}
		}

		public System.Guid UserRewardAccountTransactionId
		{
			get { return _userRewardAccountTransactionId; }
			set
			{
				Set<System.Guid>(() => UserRewardAccountTransactionId, ref _userRewardAccountTransactionId, value);
				RunCustomLogicSetUserRewardAccountTransactionId(value);
			}
		}

		public int UserRewardAccountTransactionTypeId
		{
			get { return _userRewardAccountTransactionTypeId; }
			set
			{
				Set<int>(() => UserRewardAccountTransactionTypeId, ref _userRewardAccountTransactionTypeId, value);
				RunCustomLogicSetUserRewardAccountTransactionTypeId(value);
			}
		}

		public int? Value
		{
			get { return _value; }
			set
			{
				Set<int?>(() => Value, ref _value, value);
				RunCustomLogicSetValue(value);
			}
		}

		public virtual UserRewardAccountTransactionType UserRewardAccountTransactionType { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetMemo(string value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetUserRewardAccountId(System.Guid value);
		partial void RunCustomLogicSetUserRewardAccountTransactionId(System.Guid value);
		partial void RunCustomLogicSetUserRewardAccountTransactionTypeId(int value);
		partial void RunCustomLogicSetValue(int? value);

		#endregion RunCustomLogicSet

	}
}
