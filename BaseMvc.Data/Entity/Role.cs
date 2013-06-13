using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaseMvc.Data.Entity
{
    internal class Role : BaseEntity
    {
        public Role()
        {
            Users = new List<User>();
            Permissions = new List<Permission>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
