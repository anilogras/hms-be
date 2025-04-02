using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.FronOffice
{
    public class MarketDTO : BaseDto, IBaseDto, IBaseDefinition
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
