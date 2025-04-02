using HMS.Core.Abstracts.Dto;
using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.FronOffice
{
    public class CategoryDTO : BaseDto, IBaseDto
    {
        public int Pax { get; set; }
        public int Child { get; set; }
    }
}
