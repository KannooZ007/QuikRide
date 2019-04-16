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

	public class LoadRequestHolidayTranslation : EventArgs
	{
		public LoadRequestHolidayTranslation(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class HolidayTranslation : BaseModel<IWebApiDataServiceQR>, IHolidayTranslation
	{
		public event EventHandler<LoadRequestHolidayTranslation> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.HolidayTranslation _dto = null;

		public HolidayTranslation(ILoggingService log, IDataService<IWebApiDataServiceQR> dataService) : base(log, dataService)
		{
			_dto = new xDTO.HolidayTranslation();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public HolidayTranslation(ILoggingService log, IDataService<IWebApiDataServiceQR> dataService, xDTO.HolidayTranslation dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedUtcDate { get { return _dto.CreatedUtcDate; } }
		public virtual int DataVersion { get { return _dto.DataVersion; } }
		public virtual int DisplayPriority { get { return _dto.DisplayPriority; } }
		public virtual int HolidayId { get { return _dto.HolidayId; } }
		public virtual int HolidayTranslationId { get { return _dto.HolidayTranslationId; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual int LanguageTypeId { get { return _dto.LanguageTypeId; } }
		public virtual string ModifiedBy { get { return _dto.ModifiedBy; } }
		public virtual System.DateTime ModifiedUtcDate { get { return _dto.ModifiedUtcDate; } }
		public virtual string Value { get { return _dto.Value; } }

		private IHoliday _holiday = null; // Foreign Key
		private ILanguageType _languageType = null; // Foreign Key


		public virtual IHoliday Holiday
		{
			get
			{
				if (_holiday == null)
				{
					OnLazyLoadRequest(this, new LoadRequestHolidayTranslation(nameof(Holiday)));
				}

				return _holiday;
			}
		}

		public virtual ILanguageType LanguageType
		{
			get
			{
				if (_languageType == null && _dto != null && _dto.LanguageType != null)
				{
					_languageType = new LanguageType(Log, DataService, _dto.LanguageType);
				}

				return _languageType;
			}
		}



	}
}