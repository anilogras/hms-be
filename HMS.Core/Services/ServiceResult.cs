using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Services
{
    public class ServiceResult : ServiceResultBase
    {

    }

    public class ServiceResult<T> : ServiceResultBase
    {
        public T? Data { get; set; }
        public ServiceResult()
        {
            Errors = new List<ServiceResultError>();
        }
    }

    public class ServiceResultError
    {
        public ServiceResultError(string err)
        {
            Error = err;
        }
        public string Error { get; set; }
    }
}
