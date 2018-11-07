using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace dotShop.Models
{
    public class SendData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Lenovo Y700-15",
                        Description = "Laptop 15.4 cala, Intel i7-6700HQ, 8GB RAM, 240GB SSD + 1TB HDD",
                        Category = "Laptopy",
                        Price = 3500
                    },
                    new Product
                    {
                        Name = "DELL Inspirion 5570",
                        Description = "Laptop 15.4 cala, Intel i7-8550U, 8GB RAM, 480GB SSD",
                        Category = "Laptopy",
                        Price = 400
                    },
                    new Product
                    {
                        Name = "Asus Zenbook UX330UA",
                        Description = "Laptop 13 cal, Intel i5-7200U, 12GB RAM, 240GB SSD + 1TB HDD",
                        Category = "Laptopy",
                        Price = 2950
                    },
                    new Product
                    {
                        Name = "Microsoft 3000",
                        Description = "Ergonomiczna mysz przewodowa dla lewo i prawo ręcznych",
                        Category = "Akcesoria",
                        Price = 180
                    },
                    new Product
                    {
                        Name = "Logitech M180",
                        Description = "Mysz bezprzeprzewodowa wyłącznie dla praworęcznych",
                        Category = "Akcesoria",
                        Price = 250
                    },
                    new Product
                    {
                        Name = "Corsair Harpoon",
                        Description = "Mysz przewodowa gamingowa, dla praworęcznych",
                        Category = "Akcesoria",
                        Price = 140
                    },
                    new Product
                    {
                        Name = "AOC I2476VWM",
                        Description = "Monitor 24calowy z matryca IPS",
                        Category = "Monitory",
                        Price = 600
                    },
                    new Product
                    {
                        Name = "Dell U2715H",
                        Description = "Motitor 27calowy z matrycą IPS",
                        Category = "Monitory",
                        Price = 1800
                    }
                    );
                context.SaveChanges();
            }
        }

    }
}
