using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Abstracts.Dto
{
    public interface IBaseDto
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public bool Inactive { get; set; }
    }
}
