using HMS.Core.Abstracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Dto.Base
{
    public class EnBaseDto : IBaseDto
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public bool Inactive { get; set; }
    }
}
