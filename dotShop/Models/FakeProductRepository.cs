using System.Collections.Generic;
using System.Linq;

namespace dotShop.Models
{
    public class FakeProductRepository //: IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Laptop", Price = 2000 },
            new Product {Name = "Telefon", Price = 1000 },
            new Product {Name = "Mysz", Price = 25 },
            new Product {Name = "Klawiatura", Price = 50 },
            new Product {Name = "Monitor", Price = 600 }
        }.AsQueryable<Product>();
    }
}
