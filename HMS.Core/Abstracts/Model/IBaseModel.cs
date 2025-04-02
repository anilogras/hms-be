using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Abstracts.Model
{
    public interface IBaseModel
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public bool Inactive { get; set; }
    }
}
