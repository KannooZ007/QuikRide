// <auto-generated> - Template:AutoMapperProfile, Version:1.1, Id:f3f865a7-e545-4bc4-b0ba-c9e7ee587e73
using AutoMapper;
using xDTO = CGH.QuikRide.DTO.QR;
using xENT = CGH.QuikRide.Repository.Entities.QR;

namespace CGH.QuikRide.Repository.Infrastructure
{
	public partial class QRAutoMapperProfile : Profile
	{
		public QRAutoMapperProfile()
		{
			InitializeProfile();
			InitializePartial();
		}

		partial void InitializePartial();

		private void InitializeProfile()
		{
			CreateMap<xDTO.Driver, xENT.Driver>()
				// .ForMember(d => d.Rides, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.User, opt => opt.Ignore())
				// .ForMember(d => d.Vehicle, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.Feedback, xENT.Feedback>()
				// .ForMember(d => d.FeedbackType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.FeedbackType, xENT.FeedbackType>()
				// .ForMember(d => d.Feedbacks, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.GenderType, xENT.GenderType>()
				// .ForMember(d => d.Users, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.Holiday, xENT.Holiday>()
			.ReverseMap();

			CreateMap<xDTO.LanguageType, xENT.LanguageType>()
				// .ForMember(d => d.FeedbackTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.GenderTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.NotificationTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.ReservationCancellationReasonTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.ReservationRequestCancellationReasonTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.ReservationRequestStatusTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.ReservationStatusTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.RideServiceTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.VehicleFeatureTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.VehicleStatusTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.VehicleTypes, opt => opt.Ignore()) // Reverse nav
			.ReverseMap();

			CreateMap<xDTO.Location, xENT.Location>()
				// .ForMember(d => d.DestinationLocation, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.PickupLocation, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.Reservations, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.UsersLocations, opt => opt.Ignore()) // Reverse nav
			.ReverseMap();

			CreateMap<xDTO.NotificationType, xENT.NotificationType>()
				// .ForMember(d => d.UsersNotificationTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.Reservation, xENT.Reservation>()
				// .ForMember(d => d.ReservationRequests, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.Location, opt => opt.Ignore())
				// .ForMember(d => d.ReservationCancellationReasonType, opt => opt.Ignore())
				// .ForMember(d => d.ReservationRequestOption, opt => opt.Ignore())
				// .ForMember(d => d.User, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.ReservationCancellationReasonType, xENT.ReservationCancellationReasonType>()
				// .ForMember(d => d.Reservations, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.ReservationRequest, xENT.ReservationRequest>()
				// .ForMember(d => d.DestinationLocation, opt => opt.Ignore())
				// .ForMember(d => d.PickupLocation, opt => opt.Ignore())
				// .ForMember(d => d.Reservation, opt => opt.Ignore())
				// .ForMember(d => d.ReservationRequestCancellationReasonType, opt => opt.Ignore())
				// .ForMember(d => d.ReservationRequestStatusType, opt => opt.Ignore())
				// .ForMember(d => d.User, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.ReservationRequestCancellationReasonType, xENT.ReservationRequestCancellationReasonType>()
				// .ForMember(d => d.ReservationRequests, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.ReservationRequestOption, xENT.ReservationRequestOption>()
				// .ForMember(d => d.Reservations, opt => opt.Ignore()) // Reverse nav
			.ReverseMap();

			CreateMap<xDTO.ReservationRequestStatusType, xENT.ReservationRequestStatusType>()
				// .ForMember(d => d.ReservationRequests, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.ReservationStatusType, xENT.ReservationStatusType>()
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.Ride, xENT.Ride>()
				// .ForMember(d => d.RidePositions, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.Driver, opt => opt.Ignore())
				// .ForMember(d => d.User, opt => opt.Ignore())
				// .ForMember(d => d.Vehicle, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.RidePosition, xENT.RidePosition>()
				// .ForMember(d => d.Ride, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.RideServiceType, xENT.RideServiceType>()
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.User, xENT.User>()
				// .ForMember(d => d.Drivers, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.ReservationRequests, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.Reservations, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.Rides, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.UsersLocations, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.UsersNotificationTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.GenderType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.UsersLocation, xENT.UsersLocation>()
				// .ForMember(d => d.Location, opt => opt.Ignore())
				// .ForMember(d => d.User, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.UsersNotificationType, xENT.UsersNotificationType>()
				// .ForMember(d => d.NotificationType, opt => opt.Ignore())
				// .ForMember(d => d.User, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.Vehicle, xENT.Vehicle>()
				// .ForMember(d => d.Drivers, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.Rides, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.VehicleVehicleFeatureTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.VehicleStatusType, opt => opt.Ignore())
				// .ForMember(d => d.VehicleType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.VehicleFeatureType, xENT.VehicleFeatureType>()
				// .ForMember(d => d.VehicleTypeVehicleFeatureTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.VehicleVehicleFeatureTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.VehicleStatusType, xENT.VehicleStatusType>()
				// .ForMember(d => d.Vehicles, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.VehicleType, xENT.VehicleType>()
				// .ForMember(d => d.Vehicles, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.VehicleTypeVehicleFeatureTypes, opt => opt.Ignore()) // Reverse nav
				// .ForMember(d => d.LanguageType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.VehicleTypeVehicleFeatureType, xENT.VehicleTypeVehicleFeatureType>()
				// .ForMember(d => d.VehicleFeatureType, opt => opt.Ignore())
				// .ForMember(d => d.VehicleType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.VehicleVehicleFeatureType, xENT.VehicleVehicleFeatureType>()
				// .ForMember(d => d.Vehicle, opt => opt.Ignore())
				// .ForMember(d => d.VehicleFeatureType, opt => opt.Ignore())
			.ReverseMap();

		}
	}
}