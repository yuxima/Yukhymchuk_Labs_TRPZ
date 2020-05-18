using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Reservations.Data;

namespace Reservations
{
    class ApplicationContextFactory:IDesignTimeDbContextFactory<ApplicationContext>
    {
        ApplicationContext IDesignTimeDbContextFactory<ApplicationContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;Initial Catalog=reservation;Integrated Security=True;");
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
