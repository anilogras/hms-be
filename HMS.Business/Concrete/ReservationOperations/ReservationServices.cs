using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HMS.Business.Common;
using HMS.Business.Common.GeneralOperations;
using HMS.Business.Concrete.CompanyOperations;
using HMS.Business.Services.ReservationOperations;
using HMS.Business.Services.SalesAndMarketingOperations;
using HMS.DataAccess.Common;
using HMS.DTO;
using HMS.DTO.MainDTOs.FrontOffice.ReservationModels;
using HMS.Entities.Models;
using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.MainModels.FrontOffice.FolioModels;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;

namespace HMS.Business.Concrete.ReservationOperations
{
    public class ReservationServices : GenericService<ReservationRecord>, IReservationServices, IGenericService<ReservationRecord>
    {
        DefaultValueOperations operations;
        CompanyServices companyServices;

        public ReservationServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            operations = new DefaultValueOperations();
            companyServices = new CompanyServices(unitOfWork);
        }

        public void ConnectDailyGuest(List<ReservationDaily> dailys, List<GuestDTO> dto)
        {
            if (dto.Count > 0)
            {

                IMapper _mapper;
                var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<GuestDTO, Guest>();
                    });

                _mapper = config.CreateMapper();
                foreach (ReservationDaily item in dailys)
                {
                    for (int i = 0; i < dto.Count; i++)
                    {
                        ReservastionDailyGuest guest = new ReservastionDailyGuest();
                        guest.Deleted = false;
                        guest.GuestOrder = i + 1;
                        guest.Guest = _mapper.Map<Guest>(dto[i]);
                        operations.AddValueSet(guest.Guest);
                        item.ReservastionDailyGuests.Add(guest);

                    }
                }
            }


        }

        public void CreateFolio(List<ReservationDetail> details)
        {
            foreach(ReservationDetail detail in details)
            {
                Folio folio = new Folio()
                {
                    Status = Core.Enums.FolioStatus.Open,
                    Type = Core.Enums.FolioType.Room,
                };
                operations.AddValueSet(folio);
                if(detail.Folios == null)
                {
                    detail.Folios = new List<Folio>();
                }
                detail.Folios.Add(folio);
            }
        }

        public void CreateFolioDetail(ReservationRecord record)
        {
            List<CompanyDefaultDepartments> defaultDeps = companyServices.GetCompanyDefaultDepartments(record.CompanyId);
            List<CompanyDefaultDepartments> roomDeps = defaultDeps.Where(x => x.Type == Core.Enums.DepartmanType.Room).ToList();
            foreach (ReservationDetail detail in record.ReservationDetails)
            {
                TimeSpan? dailyTS = detail.CoutDate - detail.CinDate;
                int nightCount = Convert.ToInt32(dailyTS.Value.Days);
                Folio fol = detail.Folios.Find(x => x.Type == Core.Enums.FolioType.Room);
                for (int i = 0; i < nightCount; i++)
                {
                    DateTime postDate = detail.CinDate.Value.AddDays(1);
                    Guid FolioId = fol.Id;
                    CompanyDefaultDepartments DepartmentId = roomDeps.Where(x => postDate >= x.StartDate && postDate <= x.EndDate).FirstOrDefault();
                    if (DepartmentId == null)
                    {
                        return;
                    }
                    List<CompanyDepartmentPeriod> companyDepartmentPeriods = companyServices.GetCompanyDepartmentPeriods(DepartmentId.DepartmentId, record.CompanyId);
                    CompanyDepartmentPeriod TaxId = companyDepartmentPeriods.Where(s => postDate >= s.StartDate && postDate <= s.EndDate).FirstOrDefault();
                    if (TaxId == null)
                    {
                        return;
                    }
                    FolioDetail folioDetail = new FolioDetail()
                    {
                        Amount = detail.FixedPrice ?? 0,
                        CurrencyId = detail.CurrencyId,
                        Date = postDate,
                        DepartmentId = DepartmentId.DepartmentId,
                        Deleted = false,
                        FolioId = FolioId,
                        LocalAmount = 0, // KUR OKUNARAK KURA GÖRE ÇARPILIP YAZILACAK 
                        Rate = 0, // KUR OKUNARAK YAZILACAK
                        Remark = null,
                        SourceFolioId = FolioId,
                        TaxId = TaxId.TaxId,
                        Time = DateTime.Now.TimeOfDay,
                        Type = Core.Enums.FolioDetailType.ImaginaryPosting,
                        Inactive = false,


                    };
                    if (detail.IsFixedPrice)
                    {
                        if (detail.IsFixedRate)
                        {
                            folioDetail.Rate = detail.FixedRate ?? 0;
                            folioDetail.LocalAmount = Math.Round((detail.FixedPrice * detail.FixedRate).Value, 2);
                        }
                    }
                    if (fol.FolioDetails == null)
                    {
                        fol.FolioDetails = new List<FolioDetail>();
                    }
                    fol.FolioDetails.Add(folioDetail);
                }
                
            }
        }

        public List<ReservationDaily> CreateReservationDaily(CreateReservationDaily daily)
        {
            List<ReservationDaily> dailyList = new List<ReservationDaily>();
            DateTime dateindex = daily.StartDate;
            for (int i = 0; dateindex <= daily.EndDate; i++)
            {
                ReservationDaily dailyCreate = new ReservationDaily()
                {
                    Beb = daily.Beb,
                    Child = daily.Child,
                    Date = dateindex.Date,
                    Deleted = false,
                    Free = daily.Free,
                    Inactive = false,
                    Pax = daily.Pax,
                    RoomId = daily.RoomId,
                };
                dateindex = dateindex.AddDays(1);
                dailyList.Add(dailyCreate);
            }
            return dailyList;
        }

        public List<ReservationDetail> CreateReservationDetail(List<CreateUpdateReservationDTO> dto)
        {
            List<ReservationDetail> detailList = new List<ReservationDetail>();
            int index = 1;
            foreach (CreateUpdateReservationDTO item in dto)
            {
                ReservationDetail detail = new ReservationDetail()
                {
                    CinDate = item.CinDate?.Date,
                    CoutDate = item.CoutDate?.Date,
                    CurrencyId = item.CurrencyId,
                    Deleted = false,
                    FixedPrice = item.FixedPrice,
                    FixedRate = item.FixedRate,
                    Inactive = false,
                    IsFixedPrice = item.IsFixedPrice,
                    IsFixedRate = item.IsFixedRate,
                    PriceLocationId = item.PriceLocationId,
                    ReservationOrder = index,
                    RoomLocationId = item.RoomLocationId,
                    Voucher = item.Voucher,
                    BoardingHouseId = item.BoardingHouseId,
                    MarketId = item.MarketId,
                    AgencyId = item.AgencyId
                };
                index++;
                detail.ReservationDailies = CreateReservationDaily(item.daily);
                ConnectDailyGuest(detail.ReservationDailies, item.Guests);

                detailList.Add(detail);
            }
            return detailList;
        }

        public ReservationRecord CreateReservationRecord(CreateUpdateReservationRecordDTO dto)
        {
            ReservationRecord newRecord = new ReservationRecord()
            {
                CompanyId = dto.CompanyId,
                Deleted = false,
                EnterpriseId = dto.EnterpriseId,
                GroupVoucher = dto.GroupVoucher,
                Inactive = false,
                IsGroup = dto.IsGroup,
                IsShare = dto.IsShare,
                ReferanceId = dto.ReferanceId,
            };
            return newRecord;
        }
    }
}
