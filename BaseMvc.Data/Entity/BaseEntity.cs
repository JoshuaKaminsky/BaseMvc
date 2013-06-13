using System.ComponentModel.DataAnnotations;

namespace BaseMvc.Data.Entity
{
    internal class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
