using HMS.Core.Abstracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Base
{
    public class BaseModelByNameCode : BaseModel, IBaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
