using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels
{
    public class Packets : BaseModel
    {
        public Packets()
        {
            this.EnterpriseId = new Guid("38851f4e-02e2-4193-97ac-8eef6a9fb793");
            this.CompanyId = new Guid("b5154254-c31d-4cb7-b548-7269c48d9d45");
            this.ReferanceId = new Guid("4b23d002-7de4-4674-b3ca-4af96ddab04b");
            this.Deleted = false;
        }
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }
        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; }
        public Guid PacketTypeId { get; set; }
        public PacketType PacketType { get; set; }
        public double? Ratio { get; set; }
        public double? Price { get; set; } // Yüzdelik indirim olmayabilir sabit tutar indirimi olabilir program ayarlanırken ratio boşsa price dolu olmak zorunda price boşsa ratio dolu olmak zorunda
        public Guid? AgencyId { get; set; } // Acente'ye özel paket girildiğinde burası dolu olmak zorunda
        public Agency? Agency{ get; set; }

    }
}
