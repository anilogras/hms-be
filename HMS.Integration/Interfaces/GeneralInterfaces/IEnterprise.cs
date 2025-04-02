using HMS.Core;
using HMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Integration.Interfaces.GeneralInterfaces
{
    public interface IEnterprise
    {
        public Task<ActionResponse<EnterpriseDto>> EnterpriseAdd(EnterpriseDto dto);
        public Task<ActionResponse<EnterpriseDto>> GetAllEnterprise();
        public Task<ActionResponse<EnterpriseDto>> GetByIdEnterprise(Guid Id);
        public Task<ActionResponse<EnterpriseDto>> UpdateEnterprise(EnterpriseDto dto);
        public Task<ActionResponse<EnterpriseDto>> DeleteEnterprise(Guid Id);
        public Task<ActionResponse<EnterpriseDto>> GetByIdEnterpriseINC(Guid Id);

    }
}
