using HMS.Core.Abstracts.Model;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.CommonModels
{
    public class Company :EnBaseModel, IBaseModel, IBaseDefinition
    {

        public string Name { get ; set ; }
        public Guid EnterpriseId { get; set; }
        public Enterprise Enterprise { get; set; }
        public string Code { get; set; }

        public ICollection<Referance> Referances { get; set; }
    }
}
