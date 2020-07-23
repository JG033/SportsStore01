using J.SportsStore01.Domain.Abstract;
using J.SportsStore01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.SportsStore01.Domain.Concrete
{
    public class InMemoryProductsRepository : IProductsRepository
    {
        private List<Product> _Products = new List<Product>
        {
            new Product {Name = "Football", Price=25},
            new Product {Name = "Surf board", Price=179},
            new Product {Name = "Running shoes", Price=95},
            new Product {Name = "ball", Price=95},
            new Product {Name = "shoes2", Price=95}
        };

        public IEnumerable<Product> Products
        {
            get { return _Products; }
        }
    }
}
