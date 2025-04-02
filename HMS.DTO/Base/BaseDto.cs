using HMS.Core.Abstracts.Dto;
using HMS.DTO.CommonDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Dto.Base
{
    public class BaseDto : EnBaseDto , IBaseDto
    {
        public Guid EnterpriseId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ReferanceId { get; set; }
    }
}
