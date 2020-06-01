using DataAccessLayer.Implementation.Data.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace Reservations
{
    class ApplicationContextFactory:IDesignTimeDbContextFactory<ApplicationContext>
    {
        ApplicationContext IDesignTimeDbContextFactory<ApplicationContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            //var connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var connection = @"data source=(localdb)\MSSQLLocalDB;Initial Catalog=reservation;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connection);
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
