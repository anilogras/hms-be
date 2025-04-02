using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition
{
    public class PhysicalDepartment : BaseModel
    {
        public string Name { get; set; }           // Departman adı
        public string Description { get; set; }    // Departman açıklaması (opsiyonel)
    }
}
