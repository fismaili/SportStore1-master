using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore1.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List < Product >{
        new Product{ Name="Test",Price=13},
        new Product{ Name="Test1",Price=14},
        new Product{ Name="Test2",Price=15}
        }.AsQueryable<Product>();
    }
}
