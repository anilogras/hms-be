using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO
{
    public class PhysicalDepartmentDTO : BaseDto
    {
        public string Name { get; set; }           // Departman adı
        public string Description { get; set; }    // Departman açıklaması (opsiyonel)
    }
}
