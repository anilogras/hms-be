using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Services
{
    public class ServiceResultBase
    {
        public ServiceResultBase()
        {
            Errors = new List<ServiceResultError>();
        }
        public int DataCount { get; set; }
        public bool Status { get; set; }
        public List<ServiceResultError> Errors { get; set; }
    }

}
