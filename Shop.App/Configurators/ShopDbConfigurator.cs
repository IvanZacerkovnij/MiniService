using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Shop.App.Data;

public static class ShopDbConfigurator
{
    public static void Configure(DbContextOptionsBuilder options)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var connectionString = builder.GetConnectionString("MySQLConnection");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        // options.UseSqlServer(connectionString);
    }
}