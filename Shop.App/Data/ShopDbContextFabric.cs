using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace Shop.App.Data;

public class ShopDbContextFabric : IDesignTimeDbContextFactory<ShopDbContext>
{
    public ShopDbContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var connectionString = builder.GetConnectionString("MySQLConnection");
        // var options = new DbContextOptionsBuilder<ShopDbContext>()
        //     .UseSqlServer(connectionString)
        //     .Options;
        var options = new DbContextOptionsBuilder<ShopDbContext>()
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            .Options;
        return new ShopDbContext(options);
    }
}