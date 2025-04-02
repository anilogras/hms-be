using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class ProcedureType : BaseModel
    {
        public ProcedureType()
        {
        }

        public string Name { get; set; } 
        public string Description { get; set; }
    }
}
