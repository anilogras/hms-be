using HMS.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Base
{
    public class EnBaseModel
    {
        public EnBaseModel()
        {
        }

        [Key]
        [Index("id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool Deleted { get; set; }
        public bool Inactive { get; set; }

        //public Guid CreatedUser { get; set; }


    }
}
