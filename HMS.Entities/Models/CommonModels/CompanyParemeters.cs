using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Core.Enums;
using HMS.Entities.Models.Base;

namespace HMS.Entities.Models.CommonModels
{
    public class CompanyParemeters:EnBaseModel
    {
        [Index("CompanyParemeters", 1, IsUnique =true)]
        public Parameter Parameter { get; set; }
        public string ParameterValue { get; set; }

        [Index("CompanyParemeters", 2, IsUnique = true)]
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
