using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WeixinProject.Configuration;
using WeixinProject.Web;

namespace WeixinProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WeixinProjectDbContextFactory : IDesignTimeDbContextFactory<WeixinProjectDbContext>
    {
        public WeixinProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WeixinProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WeixinProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WeixinProjectConsts.ConnectionStringName));

            return new WeixinProjectDbContext(builder.Options);
        }
    }
}
