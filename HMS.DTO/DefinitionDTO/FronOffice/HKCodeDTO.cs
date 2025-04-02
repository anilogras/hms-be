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
    public class HKCodeDTO : BaseDto, IBaseDto, IBaseDefinition
    {
        public string Color { get; set; }
        public int CleanCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
