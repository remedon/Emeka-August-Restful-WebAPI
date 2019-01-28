using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Austine.Test.Domain
{
    [Table("AppAccountBalance")]
    public class AccountBalance : Entity<long>
    {
        public long AccountId { get; set; }

        public decimal? Balance { get; set; }

        public decimal? Overdraft { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
