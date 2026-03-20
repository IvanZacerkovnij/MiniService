using Microsoft.Extensions.DependencyInjection;
using Shop.App.Data;
using Shop.Domain.Entities;
using Shop.Domain.Enum;

namespace Shop.App;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddDbContext<ShopDbContext>(options =>
        {
            ShopDbConfigurator.Configure(options);
        });



        var provider = services.BuildServiceProvider();
        

        using var scope = provider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ShopDbContext>();

        if (context.Database.CanConnect())
        {
            Console.WriteLine("Пiдключення до БД встановлено");
            User user = new User();
            user.Name = "Alex";
            user.Surname = "Smith";
            user.Email = "alex@gmail.com";
            user.Role = UserRole.ADMIN;
            user.HashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword("qwerty");
            context.Users.Add(user);
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("Не вдалось підключитись до БД");
        }
    }
}