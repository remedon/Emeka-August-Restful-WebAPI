using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Austine.Test.Domain
{
    [Table("AppAccount")]
    public class Account : Entity<long>
    {
        [StringLength(20)]
        public string Number { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Status { get; set; }
    }
}
