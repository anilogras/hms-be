using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Abstracts.Model
{
    public interface IBaseDefinition
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
