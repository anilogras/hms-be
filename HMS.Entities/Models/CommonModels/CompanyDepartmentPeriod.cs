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
    public class CompanyDepartmentPeriod : EnBaseModel,IBaseModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CompanyId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid TaxId { get; set; }
        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual Tax Tax{ get; set; }
    }
}
