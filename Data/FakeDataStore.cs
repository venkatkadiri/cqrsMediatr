using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Mediatr_and_CQRS.Models;

namespace Mediatr_and_CQRS.Data
{
    public class FakeDataStore
    {
        private static List<Product>? _products;
        public FakeDataStore()
        {
            _products = new List<Product>(){
                new Product{Id=1,Name ="New Product 1"},
                new Product{Id=2,Name ="New Product 2"},
                new Product{Id=3,Name ="New Product 3"}
            };
        }

        public async Task AddProduct(Product product)
        {
            _products?.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> getAllProducts() => await Task.FromResult(_products);

    }
}