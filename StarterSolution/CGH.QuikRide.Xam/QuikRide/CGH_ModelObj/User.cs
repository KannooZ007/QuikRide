// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace CGH.QuikRide.Xam.ModelObj.QR
{
	public partial class User : ObservableObject
	{
		public User()
		{
			Drivers = new System.Collections.Generic.List<Driver>(); // Reverse Navigation
			Reservations = new System.Collections.Generic.List<Reservation>(); // Reverse Navigation
			ReservationRequests = new System.Collections.Generic.List<ReservationRequest>(); // Reverse Navigation
			Rides = new System.Collections.Generic.List<Ride>(); // Reverse Navigation
			UsersLocations = new System.Collections.Generic.List<UsersLocation>(); // Reverse Navigation
			UsersNotificationTypes = new System.Collections.Generic.List<UsersNotificationType>(); // Reverse Navigation

			InitializePartial();
		}

		private System.DateTime? _birthDate;
		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private string _email;
		private string _firstName;
		private int _genderTypeId;
		private bool _isDeleted;
		private System.DateTime _lastLogin;
		private string _lastName;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private string _password;
		private int _preferredLanguageId;
		private string _salt;
		private int _userId;
		private string _userName;


		public System.DateTime? BirthDate
		{
			get { return _birthDate; }
			set
			{
				Set<System.DateTime?>(() => BirthDate, ref _birthDate, value);
				RunCustomLogicSetBirthDate(value);
			}
		}

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

		public string Email
		{
			get { return _email; }
			set
			{
				Set<string>(() => Email, ref _email, value);
				RunCustomLogicSetEmail(value);
			}
		}

		public string FirstName
		{
			get { return _firstName; }
			set
			{
				Set<string>(() => FirstName, ref _firstName, value);
				RunCustomLogicSetFirstName(value);
			}
		}

		public int GenderTypeId
		{
			get { return _genderTypeId; }
			set
			{
				Set<int>(() => GenderTypeId, ref _genderTypeId, value);
				RunCustomLogicSetGenderTypeId(value);
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

		public System.DateTime LastLogin
		{
			get { return _lastLogin; }
			set
			{
				Set<System.DateTime>(() => LastLogin, ref _lastLogin, value);
				RunCustomLogicSetLastLogin(value);
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set
			{
				Set<string>(() => LastName, ref _lastName, value);
				RunCustomLogicSetLastName(value);
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

		public string Password
		{
			get { return _password; }
			set
			{
				Set<string>(() => Password, ref _password, value);
				RunCustomLogicSetPassword(value);
			}
		}

		public int PreferredLanguageId
		{
			get { return _preferredLanguageId; }
			set
			{
				Set<int>(() => PreferredLanguageId, ref _preferredLanguageId, value);
				RunCustomLogicSetPreferredLanguageId(value);
			}
		}

		public string Salt
		{
			get { return _salt; }
			set
			{
				Set<string>(() => Salt, ref _salt, value);
				RunCustomLogicSetSalt(value);
			}
		}

		public int UserId
		{
			get { return _userId; }
			set
			{
				Set<int>(() => UserId, ref _userId, value);
				RunCustomLogicSetUserId(value);
			}
		}

		public string UserName
		{
			get { return _userName; }
			set
			{
				Set<string>(() => UserName, ref _userName, value);
				RunCustomLogicSetUserName(value);
			}
		}

		public virtual System.Collections.Generic.IList<Driver> Drivers { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<Reservation> Reservations { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<ReservationRequest> ReservationRequests { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<Ride> Rides { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<UsersLocation> UsersLocations { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<UsersNotificationType> UsersNotificationTypes { get; set; } // Many to many mapping
		public virtual GenderType GenderType { get; set; } 
		public virtual LanguageType LanguageType { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetBirthDate(System.DateTime? value);
		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetEmail(string value);
		partial void RunCustomLogicSetFirstName(string value);
		partial void RunCustomLogicSetGenderTypeId(int value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetLastLogin(System.DateTime value);
		partial void RunCustomLogicSetLastName(string value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetPassword(string value);
		partial void RunCustomLogicSetPreferredLanguageId(int value);
		partial void RunCustomLogicSetSalt(string value);
		partial void RunCustomLogicSetUserId(int value);
		partial void RunCustomLogicSetUserName(string value);

		#endregion RunCustomLogicSet

	}
}
