using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WeixinProject.Authorization.Roles;
using WeixinProject.Authorization.Users;
using WeixinProject.MultiTenancy;

namespace WeixinProject.EntityFrameworkCore
{
    public class WeixinProjectDbContext : AbpZeroDbContext<Tenant, Role, User, WeixinProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WeixinProjectDbContext(DbContextOptions<WeixinProjectDbContext> options)
            : base(options)
        {
        }
    }
}
