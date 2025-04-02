using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Core.Abstracts.Model;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;

namespace HMS.Entities.Models.CommonModels
{
    public class CompanyDepartments : EnBaseModel,IBaseModel
    {
        public Guid DepartmentId { get; set; }
        public Guid CompanyId{ get; set; }
        public virtual Department Department{ get; set; }
        public virtual Company Company{ get; set; }
    }
}
