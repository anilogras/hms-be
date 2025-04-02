using HMS.Core.Abstracts.Model;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.CommonModels
{
    public class Enterprise : EnBaseModel,IBaseDefinition, IBaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
