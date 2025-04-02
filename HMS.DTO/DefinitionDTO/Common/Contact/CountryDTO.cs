using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.Common.Contact
{
    public class CountryDTO : BaseDto
    {
        public CountryDTO()
        {
            States = new List<StateDTO>();
        }

        public string Name { get; set; }
        public virtual ICollection<StateDTO> States { get; set; }
    }
}
