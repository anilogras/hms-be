using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Core.Abstracts.Model;
using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;

namespace HMS.Entities.Models.CommonModels
{
    public class CompanyDefaultDepartments : EnBaseModel, IBaseModel
    {
        public Guid CompanyId { get; set; }
        public Guid DepartmentId { get; set; }
        public DepartmanType Type{ get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate{ get; set; }
        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
    }
}
