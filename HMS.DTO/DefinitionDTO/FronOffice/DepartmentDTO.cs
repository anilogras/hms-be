using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.FronOffice
{
    public class DepartmentDTO : BaseDto, IBaseDto, IBaseDefinition
    {
        public Guid TaxId { get; set; }
        public TaxDTO Tax { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
