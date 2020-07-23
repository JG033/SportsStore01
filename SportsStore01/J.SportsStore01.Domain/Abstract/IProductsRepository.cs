using J.SportsStore01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.SportsStore01.Domain.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products {get;}

    }
}
