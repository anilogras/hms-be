using HMS.Core.Abstracts.Model;
using HMS.Entities.Models.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Base
{
    public class BaseModel : EnBaseModel, IBaseModel
    {
        public Guid EnterpriseId { get; set; }
        public Enterprise Enterprise { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid? ReferanceId { get; set; }
        public Referance Referance { get; set; }
    }

}
