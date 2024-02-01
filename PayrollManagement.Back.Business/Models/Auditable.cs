using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class Auditable
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual long CreatedById { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual long? UpdatedById { get; set; }
        public virtual DateTime? LastModifiedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
    }
}
