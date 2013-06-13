using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaseMvc.Data.Entity
{
    internal class User : BaseEntity
    {
        public User()
        {
            Roles = new List<Role>();
        }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public int PasswordSalt { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
