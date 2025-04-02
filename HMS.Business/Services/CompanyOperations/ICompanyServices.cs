using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Business.Common;
using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;

namespace HMS.Business.Services.CompanyOperations
{
    public interface ICompanyServices 
    {
        List<CompanyDepartmentPeriod> GetCompanyDepartmentPeriods(Guid DepartmentId, Guid CompanyId);
        List<CompanyDefaultDepartments> GetCompanyDefaultDepartments(Guid CompanyId);
    }
}
