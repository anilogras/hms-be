using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class MedicalStaffRoleDTO : BaseDto
    {
        public MedicalStaffRoleDTO()
        {
        }

        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
