// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace CGH.QuikRide.Xam.ModelObj.QR
{
	public partial class ReservationRequest : ObservableObject
	{
		public ReservationRequest()
		{
			InitializePartial();
		}

		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private System.Guid _destinationLocationId;
		private bool _isDeleted;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private int _numberOfAdults;
		private int _numberOfBabies;
		private int? _numberOfBikes;
		private int _numberOfChildren;
		private int? _numberOfWheelchairs;
		private bool _passengerRequiresAssistance;
		private bool _personalCareAttendantIncluded;
		private System.Guid _pickupLocationId;
		private System.Guid? _replacesReservationId;
		private System.DateTime? _requestedArrivalEnd;
		private System.DateTime? _requestedArrivalStart;
		private System.DateTime? _requestedPickupEnd;
		private System.DateTime? _requestedPickupStart;
		private System.Guid? _reservationId;
		private int? _reservationRequestCancellationReasonTypeId;
		private System.Guid _reservationRequestId;
		private int _reservationRequestStatusTypeId;
		private int _userId;


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

		public System.Guid DestinationLocationId
		{
			get { return _destinationLocationId; }
			set
			{
				Set<System.Guid>(() => DestinationLocationId, ref _destinationLocationId, value);
				RunCustomLogicSetDestinationLocationId(value);
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

		public int NumberOfAdults
		{
			get { return _numberOfAdults; }
			set
			{
				Set<int>(() => NumberOfAdults, ref _numberOfAdults, value);
				RunCustomLogicSetNumberOfAdults(value);
			}
		}

		public int NumberOfBabies
		{
			get { return _numberOfBabies; }
			set
			{
				Set<int>(() => NumberOfBabies, ref _numberOfBabies, value);
				RunCustomLogicSetNumberOfBabies(value);
			}
		}

		public int? NumberOfBikes
		{
			get { return _numberOfBikes; }
			set
			{
				Set<int?>(() => NumberOfBikes, ref _numberOfBikes, value);
				RunCustomLogicSetNumberOfBikes(value);
			}
		}

		public int NumberOfChildren
		{
			get { return _numberOfChildren; }
			set
			{
				Set<int>(() => NumberOfChildren, ref _numberOfChildren, value);
				RunCustomLogicSetNumberOfChildren(value);
			}
		}

		public int? NumberOfWheelchairs
		{
			get { return _numberOfWheelchairs; }
			set
			{
				Set<int?>(() => NumberOfWheelchairs, ref _numberOfWheelchairs, value);
				RunCustomLogicSetNumberOfWheelchairs(value);
			}
		}

		public bool PassengerRequiresAssistance
		{
			get { return _passengerRequiresAssistance; }
			set
			{
				Set<bool>(() => PassengerRequiresAssistance, ref _passengerRequiresAssistance, value);
				RunCustomLogicSetPassengerRequiresAssistance(value);
			}
		}

		public bool PersonalCareAttendantIncluded
		{
			get { return _personalCareAttendantIncluded; }
			set
			{
				Set<bool>(() => PersonalCareAttendantIncluded, ref _personalCareAttendantIncluded, value);
				RunCustomLogicSetPersonalCareAttendantIncluded(value);
			}
		}

		public System.Guid PickupLocationId
		{
			get { return _pickupLocationId; }
			set
			{
				Set<System.Guid>(() => PickupLocationId, ref _pickupLocationId, value);
				RunCustomLogicSetPickupLocationId(value);
			}
		}

		public System.Guid? ReplacesReservationId
		{
			get { return _replacesReservationId; }
			set
			{
				Set<System.Guid?>(() => ReplacesReservationId, ref _replacesReservationId, value);
				RunCustomLogicSetReplacesReservationId(value);
			}
		}

		public System.DateTime? RequestedArrivalEnd
		{
			get { return _requestedArrivalEnd; }
			set
			{
				Set<System.DateTime?>(() => RequestedArrivalEnd, ref _requestedArrivalEnd, value);
				RunCustomLogicSetRequestedArrivalEnd(value);
			}
		}

		public System.DateTime? RequestedArrivalStart
		{
			get { return _requestedArrivalStart; }
			set
			{
				Set<System.DateTime?>(() => RequestedArrivalStart, ref _requestedArrivalStart, value);
				RunCustomLogicSetRequestedArrivalStart(value);
			}
		}

		public System.DateTime? RequestedPickupEnd
		{
			get { return _requestedPickupEnd; }
			set
			{
				Set<System.DateTime?>(() => RequestedPickupEnd, ref _requestedPickupEnd, value);
				RunCustomLogicSetRequestedPickupEnd(value);
			}
		}

		public System.DateTime? RequestedPickupStart
		{
			get { return _requestedPickupStart; }
			set
			{
				Set<System.DateTime?>(() => RequestedPickupStart, ref _requestedPickupStart, value);
				RunCustomLogicSetRequestedPickupStart(value);
			}
		}

		public System.Guid? ReservationId
		{
			get { return _reservationId; }
			set
			{
				Set<System.Guid?>(() => ReservationId, ref _reservationId, value);
				RunCustomLogicSetReservationId(value);
			}
		}

		public int? ReservationRequestCancellationReasonTypeId
		{
			get { return _reservationRequestCancellationReasonTypeId; }
			set
			{
				Set<int?>(() => ReservationRequestCancellationReasonTypeId, ref _reservationRequestCancellationReasonTypeId, value);
				RunCustomLogicSetReservationRequestCancellationReasonTypeId(value);
			}
		}

		public System.Guid ReservationRequestId
		{
			get { return _reservationRequestId; }
			set
			{
				Set<System.Guid>(() => ReservationRequestId, ref _reservationRequestId, value);
				RunCustomLogicSetReservationRequestId(value);
			}
		}

		public int ReservationRequestStatusTypeId
		{
			get { return _reservationRequestStatusTypeId; }
			set
			{
				Set<int>(() => ReservationRequestStatusTypeId, ref _reservationRequestStatusTypeId, value);
				RunCustomLogicSetReservationRequestStatusTypeId(value);
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

		public virtual Location DestinationLocation { get; set; } 
		public virtual Location PickupLocation { get; set; } 
		public virtual Reservation Reservation { get; set; } 
		public virtual ReservationRequestCancellationReasonType ReservationRequestCancellationReasonType { get; set; } 
		public virtual ReservationRequestStatusType ReservationRequestStatusType { get; set; } 
		public virtual User User { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetDestinationLocationId(System.Guid value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetNumberOfAdults(int value);
		partial void RunCustomLogicSetNumberOfBabies(int value);
		partial void RunCustomLogicSetNumberOfBikes(int? value);
		partial void RunCustomLogicSetNumberOfChildren(int value);
		partial void RunCustomLogicSetNumberOfWheelchairs(int? value);
		partial void RunCustomLogicSetPassengerRequiresAssistance(bool value);
		partial void RunCustomLogicSetPersonalCareAttendantIncluded(bool value);
		partial void RunCustomLogicSetPickupLocationId(System.Guid value);
		partial void RunCustomLogicSetReplacesReservationId(System.Guid? value);
		partial void RunCustomLogicSetRequestedArrivalEnd(System.DateTime? value);
		partial void RunCustomLogicSetRequestedArrivalStart(System.DateTime? value);
		partial void RunCustomLogicSetRequestedPickupEnd(System.DateTime? value);
		partial void RunCustomLogicSetRequestedPickupStart(System.DateTime? value);
		partial void RunCustomLogicSetReservationId(System.Guid? value);
		partial void RunCustomLogicSetReservationRequestCancellationReasonTypeId(int? value);
		partial void RunCustomLogicSetReservationRequestId(System.Guid value);
		partial void RunCustomLogicSetReservationRequestStatusTypeId(int value);
		partial void RunCustomLogicSetUserId(int value);

		#endregion RunCustomLogicSet

	}
}
