
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Trace
{
    public class TaskCategoryDTO : BaseDto
    {
        public string Name { get; set; }                          // Kategori adı
        public string Description { get; set; }                    // Kategori açıklaması
        public Guid? ParentCategoryId { get; set; }               // Üst kategori ID'si (opsiyonel)
        public TaskCategoryDTO ParentCategory { get; set; }          // Üst kategori (parent) referansı
    }
}
