// <auto-generated> - Template:ModelsBackedByDto, Version:1.1, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using CGH.QuikRide.API.Client.Interface;
using CGH.QuikRide.Model.QR.Interface;
using xDTO = CGH.QuikRide.DTO.QR;

namespace CGH.QuikRide.Model.QR
{

	public class LoadRequestUsersNotificationType : EventArgs
	{
		public LoadRequestUsersNotificationType(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class UsersNotificationType : BaseModel<IWebApiDataServiceQR>, IUsersNotificationType
	{
		public event EventHandler<LoadRequestUsersNotificationType> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.UsersNotificationType _dto = null;

		public UsersNotificationType(ILoggingService log, IDataService<IWebApiDataServiceQR> dataService) : base(log, dataService)
		{
			_dto = new xDTO.UsersNotificationType();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public UsersNotificationType(ILoggingService log, IDataService<IWebApiDataServiceQR> dataService, xDTO.UsersNotificationType dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedUtcDate { get { return _dto.CreatedUtcDate; } }
		public virtual int DataVersion { get { return _dto.DataVersion; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual string ModifiedBy { get { return _dto.ModifiedBy; } }
		public virtual System.DateTime ModifiedUtcDate { get { return _dto.ModifiedUtcDate; } }
		public virtual int NotificationTypeId { get { return _dto.NotificationTypeId; } }
		public virtual int UserId { get { return _dto.UserId; } }

		private INotificationType _notificationType = null; // Foreign Key
		private IUser _user = null; // Foreign Key


		public virtual INotificationType NotificationType
		{
			get
			{
				if (_notificationType == null && _dto != null && _dto.NotificationType != null)
				{
					_notificationType = new NotificationType(Log, DataService, _dto.NotificationType);
				}

				return _notificationType;
			}
		}

		public virtual IUser User
		{
			get
			{
				if (_user == null && _dto != null && _dto.User != null)
				{
					_user = new User(Log, DataService, _dto.User);
				}

				return _user;
			}
		}



	}
}