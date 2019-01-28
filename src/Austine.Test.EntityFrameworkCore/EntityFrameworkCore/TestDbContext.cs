using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Austine.Test.Authorization.Roles;
using Austine.Test.Authorization.Users;
using Austine.Test.MultiTenancy;
using Austine.Test.Domain;

namespace Austine.Test.EntityFrameworkCore
{
    public class TestDbContext : AbpZeroDbContext<Tenant, Role, User, TestDbContext>
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountBalance> AccountBalances { get; set; }
        
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }
    }
}
