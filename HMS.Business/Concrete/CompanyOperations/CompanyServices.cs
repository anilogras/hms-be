using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Business.Common;
using HMS.Business.Common.GeneralOperations;
using HMS.Business.Services.CompanyOperations;
using HMS.Business.Services.ReservationOperations;
using HMS.DataAccess.Common;
using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;

namespace HMS.Business.Concrete.CompanyOperations
{
    public class CompanyServices :  GenericService<Company>, ICompanyServices,IGenericService<Company>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Company> _companyRepository;
        private readonly IRepository<CompanyDepartmentPeriod> _companyDepartmentPeriodRepository;
        private readonly IRepository<CompanyDefaultDepartments> _companyDefaultDepartmentRepository;
        public CompanyServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _companyRepository = _unitOfWork.Repository<Company>();
            _companyDepartmentPeriodRepository = _unitOfWork.Repository<CompanyDepartmentPeriod>();
            _companyDefaultDepartmentRepository = _unitOfWork.Repository<CompanyDefaultDepartments>();

        }

        public List<CompanyDefaultDepartments> GetCompanyDefaultDepartments(Guid CompanyId)
        {
            List<CompanyDefaultDepartments> defDeps = _companyDefaultDepartmentRepository.FindByConditionAsync(x=> x.CompanyId == CompanyId && x.Deleted==false ).Result;
            return defDeps;
        }

        public List<CompanyDepartmentPeriod> GetCompanyDepartmentPeriods(Guid DepartmentId, Guid CompanyId)
        {
            List<CompanyDepartmentPeriod> departmentperiod = _companyDepartmentPeriodRepository.FindByConditionAsync(x=> x.DepartmentId == DepartmentId && x.CompanyId == CompanyId && x.Deleted== false).Result;
            return departmentperiod;
        }
    }
}
