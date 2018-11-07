using System.Linq;

namespace dotShop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
