using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PetManagement.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=MAYTINH;Database=PetManagementDb;User ID=sa;Password=dminh318;Trust Server Certificate=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
