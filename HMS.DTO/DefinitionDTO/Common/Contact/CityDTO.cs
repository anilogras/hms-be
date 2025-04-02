using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.Common.Contact
{
    public class CityDTO : BaseDto
    {

        public CityDTO()
        {
        }

        public string Name { get; set; }
        public Guid StateId { get; set; }
        public virtual StateDTO State { get; set; }
    }
}
