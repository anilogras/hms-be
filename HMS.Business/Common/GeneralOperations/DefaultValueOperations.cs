using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Common.GeneralOperations
{
    public class DefaultValueOperations
    {
        public virtual void AddValueSet(BaseModel dbData)
        {
            dbData.EnterpriseId = new Guid("38851f4e-02e2-4193-97ac-8eef6a9fb793");
            dbData.CompanyId = new Guid("b5154254-c31d-4cb7-b548-7269c48d9d45");
            dbData.ReferanceId = new Guid("4b23d002-7de4-4674-b3ca-4af96ddab04b");
            dbData.Deleted = false;
            dbData.Inactive = false;
        }

    }
}
