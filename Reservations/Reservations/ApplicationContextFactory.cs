using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Reservations.Data;
using System.Configuration;

namespace Reservations
{
    class ApplicationContextFactory:IDesignTimeDbContextFactory<ApplicationContext>
    {
        ApplicationContext IDesignTimeDbContextFactory<ApplicationContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connection);
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
