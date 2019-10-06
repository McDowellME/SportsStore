using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingStore.Models
{
    public class FakeProductRepository/* : IProductRepository */
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product
            {
                Name = "Melinda McDowell Signature Model Football",
                Price = 25
            },
            new Product
            {
                Name = "Jeans",
                Price = 179
            },
            new Product
            {
                Name = "Blouse",
                Price = 95
            },
        }.AsQueryable<Product>();
    }
}
