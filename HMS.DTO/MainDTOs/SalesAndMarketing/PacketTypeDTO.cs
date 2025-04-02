using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.SalesAndMarketing
{
    public class PacketTypeDTO : BaseDto, IBaseDto, IBaseDefinition
    {
        public PacketTypeEnum Type{ get; set; }
        public bool Additional { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
