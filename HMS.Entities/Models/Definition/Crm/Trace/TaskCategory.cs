using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Trace
{
    public class TaskCategory : BaseModel
    {
        public string Name { get; set; }                          // Kategori adı
        public string Description { get; set; }                    // Kategori açıklaması
        public Guid? ParentCategoryId { get; set; }               // Üst kategori ID'si (opsiyonel)
        public TaskCategory ParentCategory { get; set; }          // Üst kategori (parent) referansı
    }
}
