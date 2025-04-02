using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels
{
    public class PeriodPrices: BaseModel
    {
        public PeriodPrices()
        {
            this.EnterpriseId = new Guid("38851f4e-02e2-4193-97ac-8eef6a9fb793");
            this.CompanyId = new Guid("b5154254-c31d-4cb7-b548-7269c48d9d45");
            this.ReferanceId = new Guid("4b23d002-7de4-4674-b3ca-4af96ddab04b");
            this.Deleted = false;
        }
        public ContractPeriod ContractPeriod { get; set; }
        public Guid ContractPeriodId { get; set; }
        public Guid RoomLocationId { get; set; }
        public RoomLocation RoomLocation { get; set; }
        public Guid PriceTypeId { get; set; }
        public PriceType PriceType { get; set; }
        public double RawPrice { get; set; }
    }
}
