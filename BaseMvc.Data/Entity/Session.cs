using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseMvc.Data.Entity
{
    internal class Session : BaseEntity
    {
        [Required]
        public Guid SessionId { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
