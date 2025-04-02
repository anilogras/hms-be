using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels
{
    public class PriceType : BaseModel
    {
        public PriceType()
        {
            this.EnterpriseId = new Guid("38851f4e-02e2-4193-97ac-8eef6a9fb793");
            this.CompanyId = new Guid("b5154254-c31d-4cb7-b548-7269c48d9d45");
            this.ReferanceId = new Guid("4b23d002-7de4-4674-b3ca-4af96ddab04b");
            this.Deleted = false;
        }
        public string Name { get; set; }
        public int Pax { get; set; }
        public int Child { get; set; }

        [NotMapped]
        public string PaxChild  => this.Pax.ToString() + "+" + this.Child.ToString();

    }
}
