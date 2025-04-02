using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class MedicalStaffRole : BaseModel
    {
        public MedicalStaffRole()
        {
        }

        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
