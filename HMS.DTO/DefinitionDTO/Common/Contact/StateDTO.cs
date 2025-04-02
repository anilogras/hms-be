
using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.Common.Contact
{
    public class StateDTO : BaseDto
    {
        public StateDTO()
        {
            Cities = new List<CityDTO>();
        }

        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public virtual CountryDTO Country { get; set; }
        public virtual ICollection<CityDTO> Cities { get; set; }
    }
}
