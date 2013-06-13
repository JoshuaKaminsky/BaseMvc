using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaseMvc.Data.Entity
{
    internal class Permission : BaseEntity
    {
        public Permission()
        {
            Roles = new List<Role>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
