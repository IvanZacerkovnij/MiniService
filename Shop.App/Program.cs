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
            // var product = new Product()
            // {
            //     Name = "Морозиво",
            //     Price = 9.99m,
            //     CreatedAt =  DateTime.Now,
            // };
            // var category = new Categories()
            // {
            //     Name = "Солодощі",
            //     CreatedAt = DateTime.Now
            // };
            // var categoryProduct = new CategoryProduct()
            // {
            //     ProductId = 3,
            //     CategoryId = 1,
            //     Store = 20
            // };
            // context.Categories.Add(category);
            // context.CategoryProducts.Add(categoryProduct);
            // context.Products.Add(product);
            // context.SaveChanges();
        }
        else
        {
            Console.WriteLine("Не вдалось підключитись до БД");
        }
    }
}