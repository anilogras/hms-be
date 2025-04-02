using HMS.Core.Abstracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.CommonModels
{
    public class Referance : IBaseDefinition, IBaseModel
    {
        public Guid Id { get ; set ; }
        public bool Deleted { get ; set ; }
        public bool Inactive { get ; set ; }
        public string Name { get ; set ; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public string Code { get; set; }

    }
}
