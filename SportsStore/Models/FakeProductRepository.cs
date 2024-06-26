﻿using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Football", Price = 25},
            new Product {Name ="Surf Board", Price = 93},
            new Product {Name="Running shoes", Price = 323}
        }.AsQueryable<Product>();
    }
}
