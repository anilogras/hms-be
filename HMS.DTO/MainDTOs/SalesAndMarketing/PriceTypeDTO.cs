using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.SalesAndMarketing
{
    public class PriceTypeDTO : BaseDto, IBaseDto
    {
        public string Name { get; set; }
        public int Pax { get; set; }
        public int Child { get; set; }

        [NotMapped]
        public string PaxChild  => this.Pax.ToString() + "+" + this.Child.ToString();

    }
}
